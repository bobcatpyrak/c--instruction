using System;

namespace ch05_demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chapter 5 demos");
            int n = ParseInt("\nEnter a whole number");

            Console.WriteLine("\nYou entered " + n);

            PrintOrderDetails("Kroger", "Playstation 5", 5);
            PrintOrderDetails(productName: "Playstation 5", sellerName: "Kroger");

            PrintCandyStats("Snickers", 5);
            PrintCandyStats("KitKat");
            PrintFavSong("Jessica");
        }

        private static int ParseInt(String prompt)
        {
            int n = 0;
            
            while (true)
            {
                Console.WriteLine(prompt);
                try 
                { 
                    n = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Enter something valid, please");
                }
                
            }
            return n;
        }

        private static void PrintOrderDetails(String sellerName, String productName, int orderNum = 0)
        {
            Console.WriteLine("Order Details: " + productName + ", on order # " + orderNum + ", purchased at " + sellerName + ".");
        }

        private static void PrintCandyStats(String candyName, int quantity = 0)
        {
            Console.WriteLine("* " + quantity + " pieces of " + candyName);
        }

        private static void PrintFavSong(String name)
        {
            Console.WriteLine("My favorite song is " + name + ".");
            Console.WriteLine($"My favorite song is {name}.");
        }
    }
}
