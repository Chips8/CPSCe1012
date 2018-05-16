using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OriginalPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal originalPrice = 10;
            decimal increasedAmount, difference;
            double percentIncrease = 0.15, totalPercent;

            increasedAmount = originalPrice + (originalPrice * (decimal) percentIncrease); // cast our percent increase into a decimal.

            increasedAmount += increasedAmount * (decimal) percentIncrease;

            //increasedAmount = increasedAmount + (increasedAmount * (decimal)percentIncrease);

            difference = increasedAmount - originalPrice;

            totalPercent = (double)(difference / originalPrice);

            Console.WriteLine($"The final percentage is {totalPercent:p}");
            Console.ReadLine();
      

        }
    }
}
