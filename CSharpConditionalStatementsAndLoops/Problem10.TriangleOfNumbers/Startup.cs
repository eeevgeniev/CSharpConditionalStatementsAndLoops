namespace Problem10.TriangleOfNumbers
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                int[] numbers = new int[i];

                for (int a = 0; a < numbers.Length; a++)
                {
                    numbers[a] = i;
                }

                Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }
}