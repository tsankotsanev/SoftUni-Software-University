using System;
using System.Collections.Generic;
using System.Linq;

namespace ThePianist
{
    class Program
    {
        static void Main(string[] args)
        {
            var pieces = new Dictionary<string, Dictionary<string, string>>();

            var numberOfPieces = int.Parse(Console.ReadLine());

            for (var i = 0; i < numberOfPieces; i++)
            {
                var piecesInformation = Console.ReadLine()
                    .Split("|", StringSplitOptions.RemoveEmptyEntries);

                var piece = piecesInformation[0];
                var composer = piecesInformation[1];
                var key = piecesInformation[2];

                pieces.Add(piece, new Dictionary<string, string>
                {
                    {"composer", composer},
                    {"key", key}
                });
            }

            var command = Console.ReadLine();

            while (command != "Stop")
            {
                var tokens = command
                    .Split("|", StringSplitOptions.RemoveEmptyEntries);

                var action = tokens[0];
                var piece = tokens[1];

                switch (action)
                {
                    case "Add":
                        var composer = tokens[2];
                        var key = tokens[3];

                        if (pieces.ContainsKey(piece))
                        {
                            Console.WriteLine($"{piece} is already in the collection!");
                        }
                        else
                        {
                            pieces.Add(piece, new Dictionary<string, string>
                            {
                                {"composer" , composer},
                                {"key", key}
                            });

                            Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
                        }
                        break;
                    case "Remove":
                        if (pieces.ContainsKey(piece))
                        {
                            Console.WriteLine($"Successfully removed {piece}!");
                            pieces.Remove(piece);
                        }
                        else
                        {
                            Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                        }
                        break;
                    case "ChangeKey":
                        var newKey = tokens[2];

                        if (pieces.ContainsKey(piece))
                        {
                            var tempComposer = pieces[piece]["composer"];
                            pieces.Remove(piece);

                            pieces.Add(piece, new Dictionary<string, string>
                            {
                                {"composer", tempComposer},
                                {"key", newKey}
                            });

                            Console.WriteLine($"Changed the key of {piece} to {newKey}!");
                        }
                        else
                        {
                            Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                        }
                        break;
                }

                command = Console.ReadLine();
            }

            var sortedPieces = pieces
                .OrderBy(p => p.Key)
                .ThenBy(p => p.Value["composer"]);

            foreach (var piece in sortedPieces)
            {
                Console.WriteLine($"{piece.Key} -> Composer: {piece.Value["composer"]}, Key: {piece.Value["key"]}");
            }
        }
    }
}
