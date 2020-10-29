using System;

namespace ch02_demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // declare some strings
            string str1 = "Elvis";
            String str2 = "Presley";

            // using the var identifier
            var fullName = str1 + " " + str2;

            // var number; does not work
            var number = "0";
            double d1;
            double d2;

            // while loop, prompt for input, sum then prompt for continue
            String choice = "y";
            while (choice.Equals("y"))
            {
                Console.Write("Enter a decimal value: ");
                d1 = Double.Parse(Console.ReadLine());
                Console.Write("Enter a decimal value: ");
                d2 = Double.Parse(Console.ReadLine());
                Console.WriteLine("sum is: " + (d1 + d2));

                Console.Write("Continue? ");
                choice = Console.ReadLine();
            }

            // simple if statement
            Console.Write("Stoplight color(r, y, g): ");
            String lightColor = Console.ReadLine();

            if (lightColor.Equals("r"))
                Console.WriteLine("Red light. Stop!");
            else if (lightColor.Equals("y"))
                Console.WriteLine("Yellow light. Slow down.");
            else if (lightColor.Equals("g"))
                Console.WriteLine("Green light. Go!");
            else
                Console.WriteLine("Think ya put the wrong thing there, bud.");
        }
    }
}
