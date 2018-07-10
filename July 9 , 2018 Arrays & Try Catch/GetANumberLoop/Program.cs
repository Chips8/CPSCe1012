using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetANumberLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            bool validNum = false;
            int num;
            do
            {
                Console.Write("Enter a number: ");
                try
                {
                    num = int.Parse(Console.ReadLine());
                    validNum = true;
                }
                catch(Exception)
                {
                    Console.WriteLine("That was not a number. ");
                }

            } while (validNum == false);

        }
    }
}
