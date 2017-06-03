namespace Problem13.GameOfNumbers
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int magicalNumber = int.Parse(Console.ReadLine());
            bool hasMagicNumber = false;
            int counter = 0;

            int firstMagicNumber = 0;
            int secondMagicNumber = 0;

            for (int a = firstNumber; a <= secondNumber; a++)
            {
                for (int b = firstNumber; b <= secondNumber; b++)
                {
                    if (a + b == magicalNumber)
                    {
                        hasMagicNumber = true;
                        firstMagicNumber = a;
                        secondMagicNumber = b;
                    }

                    counter++;
                }
            }

            if (hasMagicNumber)
            {
                Console.WriteLine($"Number found! {firstMagicNumber} + {secondMagicNumber} = {magicalNumber}");
            }
            else
            {
                Console.WriteLine($"{counter} combinations - neither equals {magicalNumber}");
            }
        }
    }
}