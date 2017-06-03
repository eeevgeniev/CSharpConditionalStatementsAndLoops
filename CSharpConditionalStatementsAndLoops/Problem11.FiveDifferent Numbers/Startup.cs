namespace Problem11.FiveDifferent_Numbers
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            if (secondNumber - firstNumber < 4)
            {
                Console.WriteLine("No");
                return;
            }

            int index = secondNumber - firstNumber - 4;

            for (int a = firstNumber; a <= firstNumber + index; a++)
            {
                for (int b = firstNumber + 1; b <= firstNumber + index + 1; b++)
                {
                    for (int c = firstNumber + 2; c <= firstNumber + index + 2; c++)
                    {
                        for (int d = firstNumber + 3; d <= firstNumber + index + 3; d++)
                        {
                            for (int e = firstNumber + 4; e <= secondNumber; e++)
                            {
                                if (a < b && b < c && c < d && d < e)
                                {
                                    Console.WriteLine($"{a} {b} {c} {d} {e}");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}