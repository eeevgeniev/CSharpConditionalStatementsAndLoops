namespace Problem1.ChooseADrink
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            string person = Console.ReadLine();

            switch (person)
            {
                case "Athlete":
                    Console.WriteLine("Water");
                    break;
                case "Businessman":
                case "Businesswoman":
                    Console.WriteLine("Coffee");
                    break;
                case "SoftUni Student":
                    Console.WriteLine("Beer");
                    break;
                default:
                    Console.WriteLine("Tea");
                    break;
            }
        }
    }
}