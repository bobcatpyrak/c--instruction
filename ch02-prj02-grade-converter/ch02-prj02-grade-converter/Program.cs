using System;

namespace ch02_prj02_grade_converter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Letter Grade Converter.");

            String loop = "y";
            while(loop.Equals("y"))
            {
                Console.Write("\nEnter numerical grade: ");
                int grade = int.Parse(Console.ReadLine());

                if (grade >= 88)
                    Console.WriteLine("Letter Grade: A");
                else if (grade < 88 && grade >= 80)
                    Console.WriteLine("Letter Grade: B");
                else if (grade < 80 && grade >= 67)
                    Console.WriteLine("Letter Grade: C");
                else if (grade < 67 && grade >= 60)
                    Console.WriteLine("Letter Grade: D");
                else
                    Console.WriteLine("Letter Grade: F");

                Console.Write("\nContinue? (y/n): ");
                loop = Console.ReadLine();
            }
        }
    }
}
