using System;

namespace pig_dice
{
    class Program
    {
        static void Main(string[] args)
        {
            int highest = 0;

            for (int i = 0; i < 100000; i++)
            {
                int total = 0;

                total = roll(total);
                Console.WriteLine(total);
                if (total > highest)
                    highest = total;
            }
            Console.WriteLine("Highest total: " + highest);
        }

        private static int roll(int total)
        {
            var rand = new Random();

            int dots = rand.Next(1, 6);

            total += dots;

            if (dots > 1)
                total = roll(total);

            return total;
        }
    }
}
