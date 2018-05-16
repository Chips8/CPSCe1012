using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring variables

            double num1 = 6.666;
            double num2 = 5;

            double sum, product, difference;
            double quotient;

            //Math

            sum = num1 + num2;
            product = num1 * num2;
            difference = num1 - num2;
            quotient = num1 / (num2 * 1.0);

            // Display
            Console.WriteLine("The sum of " + num1 + " and " + num2 + " is " + sum + ".");
            Console.WriteLine("The product of " + num1 + " and " + num2 + " is " + product + ".");
            Console.WriteLine("The difference of " + num1 + " and " + num2 + " is " + difference + ".");
            Console.WriteLine("The quotient of " + num1 + " and " + num2 + " is " + quotient + ".");
            Console.ReadLine();

        }
    }
}
