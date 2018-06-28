using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_Part_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Update the program to allow quanitity of each item.

            const decimal TAX_PERCENT = 0.05m;
            const int MAX_SIZE = 5;
            decimal[] prices = new decimal[MAX_SIZE];
            string[] description = new string[MAX_SIZE];
            int[] quantity = new int[MAX_SIZE];

            decimal subtotal = 0, tax, total;

            for (int index = 0; index < MAX_SIZE; index++)
            {
                //interpolation method
                Console.Write($"Enter a description #{index +1}:");
                description[index] = Console.ReadLine();

                Console.Write($"Enter price #{index+1}: ");
                prices[index] = decimal.Parse(Console.ReadLine());

                Console.WriteLine($"Enter the quantity #{index+1}:");
                quantity[index] = int.Parse(Console.ReadLine());

                subtotal = subtotal + (prices[index] * quantity[index]);
            }

            for (int index = 0; index < MAX_SIZE; index++)
            {
                //50 & 10
                // default is right aligned
                // negative is left aligned
                Console.WriteLine("{0,-50}{1,4}{2,10}{3,10}", "Description ", "Quantity ", "Price per ", "Calculated " );
                // if too small will change alignment, go big first.
                Console.WriteLine("{0,-50}{1,4}{2,10:C2}{3,10:C2}", description[index], quantity[index], prices[index], quantity[index] * prices[index]);
                // non-interpolation method: "{ 0:C2}", Variable
            }

            tax = subtotal * TAX_PERCENT;
            total = subtotal + tax;

            Console.WriteLine("{0, -70} {1, 10:C2}", "Subtotal: ", subtotal);
            Console.WriteLine("{0, -70} {1, 10:C2}", "Tax: ", tax);
            Console.WriteLine("{0, -70} {1, 10:C2}", "Total: ", total); // 0 means the 1st item to be stored.
            Console.ReadKey();
        }
    }
}
