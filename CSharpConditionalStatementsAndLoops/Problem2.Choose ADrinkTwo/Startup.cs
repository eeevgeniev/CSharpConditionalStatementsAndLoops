namespace Problem2.Choose_ADrinkTwo
{
    using System;
    using System.Globalization;
    using System.Threading;

    public class Startup
    {
        public static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            string person = Console.ReadLine();
            int drinksCount = int.Parse(Console.ReadLine());

            switch (person)
            {
                case "Athlete":
                    Console.WriteLine($"The {person} has to pay {(drinksCount * 0.7):f2}.");
                    break;
                case "Businessman":
                case "Businesswoman":
                    Console.WriteLine($"The {person} has to pay {(drinksCount * 1):f2}.");
                    break;
                case "SoftUni Student":
                    Console.WriteLine($"The {person} has to pay {(drinksCount * 1.7):f2}.");
                    break;
                default:
                    Console.WriteLine($"The {person} has to pay {(drinksCount * 1.2):f2}.");
                    break;
            }
        }
    }
}