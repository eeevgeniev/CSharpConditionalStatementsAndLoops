namespace Problem15.NeighbourWars
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            Player pesho = new Player() { Name = "Pesho", Health = 100, AttackName = "Roundhouse kick" };
            Player gosho = new Player() { Name = "Gosho", Health = 100, AttackName = "Thunderous fist" };

            int round = 1;

            pesho.Damage = int.Parse(Console.ReadLine());
            gosho.Damage = int.Parse(Console.ReadLine());

            while (true)
            {
                if (round % 2 == 1)
                {
                    gosho.Health -= pesho.Damage;

                    if (gosho.Health <= 0)
                    {
                        Console.WriteLine($"{pesho.Name} won in {round}th round.");

                        break;
                    }

                    Console.WriteLine($"{pesho.Name} used {pesho.AttackName} and reduced {gosho.Name} to {gosho.Health} health.");
                }
                else
                {
                    pesho.Health -= gosho.Damage;

                    if (pesho.Health <= 0)
                    {
                        Console.WriteLine($"{gosho.Name} won in {round}th round.");

                        break;
                    }

                    Console.WriteLine($"{gosho.Name} used {gosho.AttackName} and reduced {pesho.Name} to {pesho.Health} health.");
                }

                if (round % 3 == 0)
                {
                    gosho.Health += 10;
                    pesho.Health += 10;
                }

                round++;
            }
        }
    }

    internal class Player
    {
        public string Name { get; set; }

        public int Health { get; set; }

        public int Damage { get; set; }

        public string AttackName { get; set; }
    }
}