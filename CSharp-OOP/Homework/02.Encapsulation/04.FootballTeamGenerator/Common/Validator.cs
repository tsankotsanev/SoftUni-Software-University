namespace _04.FootballTeamGenerator.Common
{
    public static class Validator
    {
        public const int MinValueOfStats = 0;
        public const int MaxValueOfStats = 100;

        public static string InvalidRating =
            "{0} should be between {1} and {2}.";

        public static string InvalidName =
            "A {0} should not be empty.";

        public static string InvalidPlayerName =
             "Player {1} is not in {2} team.";

        public static string InvalidTeamName =
            "Team {0} does not exist.";

    }
}
