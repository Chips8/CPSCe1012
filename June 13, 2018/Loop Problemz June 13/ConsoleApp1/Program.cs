using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            double result;
            Console.Write("Enter first number: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            num2 = int.Parse(Console.ReadLine());
            Console.Write("Enter third number: ");
            num3 = int.Parse(Console.ReadLine());

            result = FindAverage(num1, num2, num3);
            Console.WriteLine($"The average of {num1} {num2} {num3} is {result}");
            Console.ReadKey();

        }
        static double FindAverage(int number1, int number2, int number3)
        {
            double result;
            result = (number1 + number2 + number3) / 3.0;
            return result;
        }
    }

}
