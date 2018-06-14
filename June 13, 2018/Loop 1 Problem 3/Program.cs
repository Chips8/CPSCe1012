using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_1_Problem_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string input, newString="", tempString;

            Console.WriteLine("Enter a number: ");
            input = Console.ReadLine();

            foreach ( char item in input)
            {
                tempString = newString;
                newString = item + "\n" + tempString;
                newString = tempString + "\n" + item;
            }
            Console.WriteLine(newString);
            Console.ReadKey();
        }
    }
}
