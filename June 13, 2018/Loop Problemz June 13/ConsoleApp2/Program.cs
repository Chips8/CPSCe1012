using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string fName, lName, greeting;
            Console.Write("Enter first name: ");
            fName = Console.ReadLine();
            Console.Write("Enter last name: ");
            lName = Console.ReadLine();
            greeting = GenerateGreeting(fName, lName);
            Console.WriteLine(greeting);
            Console.ReadKey();

        }
        static string GenerateGreeting( string firstName, string lastName)
        {
            string result;
            result = "Welcome " + firstName + " " + lastName;
            return result;
            //return "Welcome " + firstName + " " + lastName; 
        }
        
    }
}
