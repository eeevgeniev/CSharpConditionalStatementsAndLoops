namespace Problem4.Hotel
{
    using System;
    using System.Globalization;
    using System.Threading;

    public class Startup
    {
        public static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            decimal studioPrice = 0M;
            decimal doublePrice = 0M;
            decimal suitePrice = 0M;

            switch (month)
            {
                case "May":
                case "October":
                    if (nights <= 7)
                    {
                        studioPrice = 50M * nights;
                    }
                    else
                    {
                        if (month == "October")
                        {
                            studioPrice = (50M * 0.95M) * (nights - 1);
                        }
                        else
                        {
                            studioPrice = (50M * 0.95M) * nights;
                        }
                    }

                    doublePrice = 65M * nights;
                    suitePrice = 75M * nights;
                    break;
                case "June":
                case "September":
                    if (month == "September")
                    {
                        studioPrice = 60M * (nights - 1);
                    }
                    else
                    {
                        studioPrice = 60M * nights;
                    }

                    if (nights <= 14)
                    {
                        doublePrice = 72M * nights;
                    }
                    else
                    {
                        doublePrice = (72M * 0.90M) * nights;
                    }

                    suitePrice = 82M * nights;
                    break;
                case "July":
                case "August":
                case "December":
                    studioPrice = 68M * nights;
                    doublePrice = 77M * nights;

                    if (nights <= 14)
                    {
                        suitePrice = 89M * nights;
                    }
                    else
                    {
                        suitePrice = (89M * 0.85M) * nights;
                    }
                    
                    break;
            }

            Console.WriteLine($"Studio: {studioPrice:f2} lv.");
            Console.WriteLine($"Double: {doublePrice:f2} lv.");
            Console.WriteLine($"Suite: {suitePrice:f2} lv.");
        }
    }
}