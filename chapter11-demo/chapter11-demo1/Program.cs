using System;

namespace chapter11_demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arrays demo!");

            int[] nbrs = { 2, 4, 6, 8, 10, 50, 100 };
            double[] prices = new double[3];
            prices[0] = 11.99;
            prices[1] = 55.99;
            prices[2] = 2.99;

            foreach (int n in nbrs)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine($"The second element in prices is {prices[1]}.");
        }
    }
}
