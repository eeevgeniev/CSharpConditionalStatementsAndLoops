namespace Problem8.CaloriesCounter
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            int counter = int.Parse(Console.ReadLine());
            int totalCalories = 0;

            for (int i = 0; i < counter; i++)
            {
                string ingredient = Console.ReadLine();

                if (string.Equals(ingredient, "Cheese", StringComparison.InvariantCultureIgnoreCase))
                {
                    totalCalories += 500;
                }
                else if (string.Equals(ingredient, "Tomato sauce", StringComparison.InvariantCultureIgnoreCase))
                {
                    totalCalories += 150;
                }
                else if (string.Equals(ingredient, "Salami", StringComparison.InvariantCultureIgnoreCase))
                {
                    totalCalories += 600;
                }
                else if (string.Equals(ingredient, "Pepper", StringComparison.InvariantCultureIgnoreCase))
                {
                    totalCalories += 50;
                }
            }

            Console.WriteLine($"Total calories: {totalCalories}");
        }
    }
}