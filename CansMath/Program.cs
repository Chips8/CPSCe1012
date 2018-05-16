using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CansMath
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfCans = 72;
            decimal pricePerCan = 0.40m;
            double discountPercentage = 0.15;
            decimal discountPricePerCan = pricePerCan - (pricePerCan * (decimal)discountPercentage);

            decimal totalCost = discountPricePerCan * numOfCans;
            Console.WriteLine($"The price for {numOfCans} is {totalCost:c}");
            Console.WriteLine("Price for {0} cans is ${1:0.000}", numOfCans, totalCost);
            Console.ReadLine();
        }
    }
}
