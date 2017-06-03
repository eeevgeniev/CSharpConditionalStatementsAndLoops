namespace Problem6.IntervalOfNumbers
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            if (firstNumber > secondNumber)
            {
                int tempNumber = firstNumber;
                firstNumber = secondNumber;
                secondNumber = tempNumber;
            }

            for (int i = firstNumber; i <= secondNumber; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}