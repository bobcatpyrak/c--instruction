using System;

namespace ch02_prj03_rectangle_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Area and Perimeter Calculator");

            String loop = "y";
            while(loop.Equals("y"))
            {
                Console.Write("\nEnter length: ");
                int l = int.Parse(Console.ReadLine());
                Console.Write("Enter width: ");
                int w = int.Parse(Console.ReadLine());
                Console.WriteLine("Area: " + (l * w));
                Console.WriteLine("Perimiter: " + (l + l + w + w));

                Console.Write("\nContinue? (y/n): ");
                loop = Console.ReadLine();
            }
        }
    }
}
