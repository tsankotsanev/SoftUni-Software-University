namespace _02.ShoppingSpree.Common
{
    public static class GlobalConstants
    {
        public static string InvalidInputNameExceptionMessage =
            "{0} cannot be empty";
        public static string InvalidMoneyExceptionMessage =
            "{0} cannot be negative";
        public static string InsufficientMoneyExceptionMessage =
            "{0} can't afford {1}";
        public const decimal CostMinValue = 0;
    }
}
