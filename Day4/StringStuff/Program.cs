using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Clarence";
            string lastName = "Wong";


            //Methods with same results

                Console.WriteLine( "Hello " + firstName + " " + lastName);

                Console.WriteLine( "Hello {0} {1}", firstName, lastName);

            //Interpolation Method
                Console.WriteLine( $"Hello {firstName} {lastName}");

            //double is the "default" so you have to use the m to make the machine understand it is a decimal
            //cents value
            decimal pricePerLitre = 119.9m;
            //dollar value
            decimal pricePerLitreInDollars = pricePerLitre / 100;

            Console.WriteLine($"The price per litres in dollars is {pricePerLitreInDollars}");
            Console.WriteLine($"The price per litres in dollars is {pricePerLitre}");
            Console.WriteLine("A litre costs {0:C2}", pricePerLitreInDollars);
                //c is currency, 




            Console.ReadLine();



        }
    }
}
