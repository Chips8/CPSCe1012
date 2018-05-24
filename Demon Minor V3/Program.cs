using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demon_Minor_V3
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            const int ageOfMajority = 18;
            string displayMessage;

            Console.WriteLine("What is your age?");
            age = int.Parse(Console.ReadLine());

            if (age < ageOfMajority)
            {
                displayMessage = "Minors not allowed.";
            }
            else
            {
                displayMessage = "Welcome adult!";
            }
            Console.WriteLine(displayMessage);
            Console.ReadKey();
        }
    }
}
