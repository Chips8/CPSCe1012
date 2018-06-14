using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleEmpty
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 5;

            for (int i = 1; i <= input; i++)
            {
                int numberOfSpace = input - i;
                for (int j = 0; j < numberOfSpace*2; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j < i * 2; j++)
                {
                    //Remove if to get filled triangle.
                    if (j == 1 || j == (i * 2 - 1) || i == input)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                    //Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
