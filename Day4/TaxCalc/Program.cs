using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalc
{
    class Program
    {
        static void Main(string[] args)
        {
 

            decimal price1 = 69.99m;
            decimal price2 = 12.25m;
            decimal tax, total, subtotal;
            int taxPercent = 5;
            subtotal = price1 + price2;
            tax = subtotal * (taxPercent / 100m);
            total = tax + subtotal;

            Console.WriteLine("{0,-20} {1,10} {2,10}", "Product $", "Qty", "Total $");
            Console.WriteLine($"{"Product 1 is " + price1,-20} {"1",10} {price1,10:C2}");
            Console.WriteLine($"{"Product 1 is " + price1,-20} {"1",10} {price1,10:C2}");
            //cannot use c2 for first price1? Beause we use the variable price 1 on 3rd table on c2?

            Console.WriteLine($"{"Subtotal:",30} {subtotal,10:C}");
            Console.WriteLine($"{"Tax:",30 } {tax,10:C2}");
            Console.WriteLine($"{"Total:", 30} {total,10:C2}");

            Console.ReadKey();


        }


    }
}
