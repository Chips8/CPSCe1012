using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Highest_of_2_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNum, secondNum, highestNum;
            string message;

            Console.WriteLine("Please enter the first number!");
            firstNum = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the SECOND number!");
            secondNum = double.Parse(Console.ReadLine());

            if ( firstNum < secondNum )
            {
                highestNum = secondNum;
                message = $"Highest Number is Second: {highestNum}";
            }
            else
            {
                highestNum = firstNum;
                message = $"Highest Number is First: {highestNum}";
            }

            Console.WriteLine(message);
            Console.ReadLine();

        }
    }
}
