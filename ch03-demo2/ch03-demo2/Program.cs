using System;

namespace ch03_demo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Math class and Random #'s");

            Random rand = new Random();


            int r1 = rand.Next(1, 6);
            Console.WriteLine("r1 = " + r1);

            double d1 = rand.NextDouble();
            Console.WriteLine(d1);
            Console.WriteLine(Math.Round(d1));
            Console.WriteLine(Math.Round(d1, 4));
            Console.WriteLine(Math.Round(d1, 4, MidpointRounding.ToEven));
        }
    }
}
