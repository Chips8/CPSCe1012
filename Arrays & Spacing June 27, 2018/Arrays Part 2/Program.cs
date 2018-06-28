using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a program to enter 5 prices, add 5% tax and display total.
            // Update the program to allow for a description of the item,
            // Update teh program to display (in columns).

            const decimal TAX_PERCENT = 0.05m;
            const int MAX_SIZE = 5;
            decimal[] prices = new decimal[MAX_SIZE];
            string[] description = new string[MAX_SIZE];

            decimal subtotal = 0, tax, total;

            for (int index = 0; index < MAX_SIZE; index++)
            {
                //interpolation method
                Console.Write($"Enter price #{index}: ");
                prices[index] = decimal.Parse(Console.ReadLine());
                subtotal = subtotal + prices[index];
                Console.Write("Enter a description: ");
                description[index] = Console.ReadLine();
            }

            for (int index = 0; index < MAX_SIZE; index++)
            {
                //50 & 10
                // default is right aligned
                // negative is left aligned
                Console.WriteLine("{0,-50}{1,10:C2}", description[index], prices[index]);
            }

            tax = subtotal * TAX_PERCENT;
            total = subtotal + tax;

            Console.WriteLine("{0, -20} {1, 10:C2}", "Subtotal: ", subtotal);
            Console.WriteLine("{0, -20} {1, 10:C2}", "Tax: ", tax);
            Console.WriteLine("{0, -20} {1, 10:C2}", "Total: ", total); // 0 means the 1st item to be stored.
            Console.ReadKey();
        }
    }
}
