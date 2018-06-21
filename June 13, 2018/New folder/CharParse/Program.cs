using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharParse
{
    class Program
    {
        static void Main(string[] args)
        {
            char menu;

            Console.WriteLine("Enter a choice (A, B, C, or D): ");

            while(char.TryParse(Console.ReadLine().ToUpper(), out menu) == false || menu != 'A' && menu != 'B')
            {
                Console.WriteLine("Invalid Choice, Try Again.");
                Console.Write("Enter a choice ( A, B, C, or D): ");

            }
            Console.WriteLine("Good-Bye");
            Console.ReadKey();
        }
    }
}
