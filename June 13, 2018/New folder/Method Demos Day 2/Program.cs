using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Demos_Day_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            bool validInt;

            Console.Write("Enter a number: ");

            validInt = int.TryParse(Console.ReadLine(), out number); //trying to Parse
            
            // Simplest form TryParse
            if(validInt == true)
            {
                Console.WriteLine("You entered a valid number");
            }
            else
            {
                Console.WriteLine("You entered an invalid number");
            }
            Console.ReadKey();
            
        }
    }
}
