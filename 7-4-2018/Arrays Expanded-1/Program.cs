using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_Expanded_1
{
    class Program
    {
        static void Main(string[] args)
        {
            const decimal TAX_PERCENT = 0.05m;
            const int MAX_SIZE = 5;
            decimal[] prices = new decimal [MAX_SIZE];
            string[] description = new string[MAX_SIZE];
            int[] quantity = new int[MAX_SIZE];
            bool addMore = true;
            decimal subtotal = 0, tax, total;
            string temp;

            for (int index = 0; index < MAX_SIZE; index++)
            {
                Console.Write($"Enter a description # {index + 1}");
                    temp = Console.ReadLine();

                    if(temp =="0")
                {
                    addMore = false;

                }
                    else
                {
                    description[index] = temp;

                    Console.Write($"Enter price #{index}: ");
                    prices[index] = decimal.Parse(Console.ReadLine());

                    subtotal = subtotal + prices[index];
                    Console.Write("Enter a quantity: ");
                    quantity[index] = int.Parse(Console.ReadLine());
                }

            }


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
    }
}
