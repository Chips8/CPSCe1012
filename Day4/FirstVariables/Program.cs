using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            string lastName;


                firstName = "Mickey";
                lastName = "Mouse";
            /*
             *  vs
            string firstName = "Mickey";
            string lastName = "Mouse";
            */
                     Console.WriteLine("Hello " + firstName + " " + lastName);
                     Console.ReadLine();
        }
    }
}
