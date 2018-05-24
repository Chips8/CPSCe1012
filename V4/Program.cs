using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V4
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, message;
            Console.WriteLine("Enter your name: ");
            name = Console.ReadLine();
            name = name.ToUpper();

            //name = Console.ReadLine().ToUpper(); works as well

            //if (name == "MICHELLE") ;
            if (name.Equals("MICHELLE"))
            //if (!name.Equals("MICHELLE")); is NOT equals to!
            {
                message = "Awesome name!";
            }
            else
            {
                message = "TOO BAD HAHA";
            }
            Console.WriteLine(message);
            Console.ReadKey();


        }
    }
}
