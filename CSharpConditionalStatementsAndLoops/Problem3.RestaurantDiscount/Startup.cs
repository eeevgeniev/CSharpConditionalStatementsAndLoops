namespace Problem3.RestaurantDiscount
{
    using System;
    using System.Globalization;
    using System.Threading;

    public class Startup
    {
        public static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            int groupCount = int.Parse(Console.ReadLine());
            string status = Console.ReadLine();

            string hallName = string.Empty;
            decimal price = 0M;
            decimal totalPrice = 0M;

            if (groupCount <= 50)
            {
                hallName = "Small Hall";
                price = 2500M;
            }
            else if (groupCount <= 100)
            {
                hallName = "Terrace";
                price = 5000M;
            }
            else if (groupCount <= 120)
            {
                hallName = "Great Hall";
                price = 7500M;
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
                return;
            }

            switch (status)
            {
                case "Gold":
                    totalPrice = ((price + 750) - ((price + 750) / 10)) / groupCount;
                    break;
                case "Normal":
                    totalPrice = ((price + 500) - ((price + 500) / 20)) / groupCount;
                    break;
                case "Platinum":
                    totalPrice = ((price + 1000) - ((price + 1000) * 3 / 20)) / groupCount;
                    break;
            }

            Console.WriteLine($"We can offer you the {hallName}");
            Console.WriteLine($"The price per person is {totalPrice:f2}$");
        }
    }
}