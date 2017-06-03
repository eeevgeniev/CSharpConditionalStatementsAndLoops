namespace Problem9.CountTheIntegers
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            int counter = 0;

            while (true)
            {
                int number;

                if (int.TryParse(Console.ReadLine(), out number))
                {
                    counter += 1;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(counter);
        }
    }
}