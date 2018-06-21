using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace More_Complicated_TryParse_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;


            Console.WriteLine("Enter a number: ");
            

            while(int.TryParse(Console.ReadLine(), out number ) == false)
            {
                Console.WriteLine("That was Invalid. Try again.");
                Console.WriteLine("Enter a number: ");
            }


            while(!int.TryParse(Console.ReadLine(), out number ))
            {
                Console.WriteLine("That was Invalid. Try again.");
                Console.WriteLine("Enter a number: ");
            }

            Console.ReadKey();
        }
    }
}
