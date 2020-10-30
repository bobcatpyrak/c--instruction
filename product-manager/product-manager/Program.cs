
using product_manager.business;
using System;

namespace product_manager
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Product Manager!");

            Product p1 = new Product();
            p1.code = "Java";
            p1.description = "Murach's Java Programming";
            p1.price = 59.50;

            Product p2 = new Product(".net", "Murach's .Net", 59.00);



        }
    }
}