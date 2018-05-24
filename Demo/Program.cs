using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            int age;
            const int ageOfMajority = 18; //constants MUST be set with a value because it is a constant

            Console.WriteLine("Enter age: ");
            //ageOfMajority = Console.ReadLine(); //cannot assign a value to a constant.
            age = int.Parse(Console.ReadLine()); //Console.ReadLine() gives us a string so we must use a Parse.

            if (age < ageOfMajority)
            {
                Console.WriteLine("You are a minor!");
            }
            else
            { 
                Console.WriteLine("You are an adult! :(");
            }


            Console.ReadLine();

        }
    }
}
