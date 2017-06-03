namespace Problem14.MagicLetter
{
    using System;
    using System.Text;

    public class Startup
    {
        public static void Main()
        {
            StringBuilder builder = new StringBuilder();

            char startChar = char.Parse(Console.ReadLine());
            char endChar = char.Parse(Console.ReadLine());
            char notAllowedLetter = char.Parse(Console.ReadLine());

            for (char a = startChar; a <= endChar; a++)
            {
                for (char b = startChar; b <= endChar; b++)
                {
                    for (char c = startChar; c <= endChar; c++)
                    {
                        if (a == notAllowedLetter || b == notAllowedLetter || c == notAllowedLetter)
                        {
                            continue;
                        }

                        builder.Append($" {a}{b}{c}");
                    }
                }
            }

            Console.WriteLine(builder.ToString().Trim());
        }
    }
}