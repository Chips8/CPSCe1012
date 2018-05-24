using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Highest_of_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double first, second, third, highest;
            string message;

            //Prompt User

            Console.WriteLine("What is the First number?");
            first = double.Parse(Console.ReadLine());

            Console.WriteLine("What is the Second number?");
            second = double.Parse(Console.ReadLine());

            Console.WriteLine("What is the Third number?");
            third = double.Parse(Console.ReadLine());

            if (first > second)
            {
                highest = first;
                message = $"First is highest: {highest}";
            }
            else
            {
                highest = second;
                message = $"Second is highest : {second}";

            }


            if (third > highest)
            {
                highest = third;
                message = $"Third is highest: {highest}";
            }
            
            Console.WriteLine(message);
            Console.ReadLine();
        }
    }
}
