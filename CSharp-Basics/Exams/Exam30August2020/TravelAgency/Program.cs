using System;

namespace TravelAgency
{
    class Program
    {
        static void Main(string[] args)
        {
            var ticketsCount = int.Parse(Console.ReadLine());
            var clientBudget = int.Parse(Console.ReadLine());
            var pricePerTicket = int.Parse(Console.ReadLine());

            var ticketsSold = ticketsCount * pricePerTicket;
            
            if (clientBudget >= ticketsSold)
            {
                Console.WriteLine($"You can sell your client {ticketsCount} tickets for the price of {ticketsSold}$!");
                Console.WriteLine($"Your client should become a change of {Math.Abs(ticketsSold - clientBudget)}$!");
            }
            else
            {
                Console.WriteLine($"The budget of {clientBudget}$ is not enough. Your client can't buy {ticketsCount} tickets with this budget!");
            }
        }
    }
}
