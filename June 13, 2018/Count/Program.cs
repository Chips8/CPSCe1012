using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count
{
    class Program
    {
        static void Main(string[] args)
        {
            int input= 0, sum = 0, count = 0;
            double average;
            
            do
            {
                Console.Write("Enter a positive age: ");
                input = int.Parse(Console.ReadLine());

                if( input < 0 )
                {
                    Console.WriteLine("Display is Invalid");
                }
                else
                {
                    if( input > 0 )
                    {
                        sum += input;
                        count++;
                    }
                }


            } while (input != 0);

            if (sum != 0)
            {
                average = sum / (count * 1.0);
                Console.WriteLine("The average is " + average);
            }
            else
            {
                Console.WriteLine("You did not enter any ages, no calculations done");
            }

            Console.ReadLine();
        }
    }
}
