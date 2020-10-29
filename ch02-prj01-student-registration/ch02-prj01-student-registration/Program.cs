using System;

namespace ch02_prj01_student_registration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Student Registration Form\n");

            Console.Write("Enter first name: ");
            String first = Console.ReadLine();
            Console.Write("Enter last name: ");
            String last = Console.ReadLine();
            Console.Write("Enter year of birth: ");
            String year = Console.ReadLine();

            Console.WriteLine("\nWelcome " + first + " " + last + "!\n" +
                                "Your registration is complete.\n" +
                                "Your temporary password is: " + first + "*" + year);
        }
    }
}
