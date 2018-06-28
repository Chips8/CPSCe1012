using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace June_27__2018
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a program to enter 5 prices, add 5% tax and display total.

            const decimal TAX_PERCENT = 0.05m;
            const int MAX_SIZE = 5;
            decimal[] prices = new decimal[MAX_SIZE];
            decimal subtotal = 0, tax, total;

            for (int index = 0; index < MAX_SIZE; index++)
            {
                //interpolation method
                Console.Write($"Enter price #{index}: ");
                prices[index] = decimal.Parse(Console.ReadLine());
                subtotal = subtotal + prices[index];
            }

            tax = subtotal * TAX_PERCENT;
            total = subtotal + tax;

            Console.WriteLine("Subtotal: " + subtotal);
            Console.WriteLine("Tax:" + tax);
            Console.WriteLine("Total: " + total);
            Console.ReadKey();
        }
    }
}
