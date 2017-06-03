namespace Problem7.CakeIngredients
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            int counter = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (!string.Equals(input, "bake!", StringComparison.InvariantCultureIgnoreCase))
                {
                    Console.WriteLine($"Adding ingredient {input}.");
                    counter += 1;
                }
                else
                {
                    Console.WriteLine($"Preparing cake with {counter} ingredients.");
                    break;
                }
            }
        }
    }
}