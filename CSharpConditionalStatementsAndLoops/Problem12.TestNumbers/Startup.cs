namespace Problem12.TestNumbers
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int sumBoundary = int.Parse(Console.ReadLine());
            int combinations = 0;
            int sum = 0;
            bool exitFor = false;

            for (int a = firstNumber; a >= 1; a--)
            {
                for (int b = 1; b <= secondNumber; b++)
                {
                    int number = a * b;

                    combinations++;
                    sum += number * 3;

                    if (sum >= sumBoundary)
                    {
                        exitFor = true;
                        break;
                    }
                }

                if (exitFor)
                {
                    break;
                }
            }

            Console.WriteLine($"{combinations} combinations");

            if (sum >= sumBoundary)
            {
                Console.WriteLine($"Sum: {sum} >= {sumBoundary}");
            }
            else
            {
                Console.WriteLine($"Sum: {sum}");
            }
        }
    }
}