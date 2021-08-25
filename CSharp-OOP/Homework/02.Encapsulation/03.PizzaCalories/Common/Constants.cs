namespace _03.PizzaCalories.Common
{
    public static class Constants
    {
        public static string InvalidArgumentOfDough =
            "Invalid type of dough.";
        public static string InvalidOperationForGramOfDough =
            "Dough weight should be in the range[{0}..{1}].";
        public static string InvalidArgumentOfTopping =
          "Cannot place {0} on top of your pizza.";
        public static string InvalidOperationForGramOfTopping =
       "{0} weight should be in the range [{1}..{2}].";
        public static string InvalidOperationForToppingCount = 
            "Number of toppings should be in range [{0}..{1}].";
        public static string InvalidArgumentLengthOfPizzaName =
            "Pizza name should be between {0} and {1} symbols.";

        public const double MinCaloriesPerGram = 2;
        public const double MinWeightForDough = 1;
        public const double MaxWeightForDough = 200;

        public const double MinWeightForTopping = 1;
        public const double MaxWeightForTopping= 50;

        public const int MaxCountOfToppings = 10;

        public const int MaxLengthOfPizzaName = 15;
        public const int MinLengthOfPizzaName = 1;
    }
}
