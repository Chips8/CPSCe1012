using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Box
{
    class Program
    {
        static void Main(string[] args)
        {
            package myPkg = new package();
            myPkg.Height = GetNumber();
            myPkg.Length = GetNumber();
            myPkg.Width = GetNumber();

            Console.WriteLine($"The volume of the package is {myPkg.GetVolume()} and the surface area is {myPkg.GetSurfaceAreas()}");
            Console.ReadKey();
        }
        static int GetNumber()
        {
            int number;
            Console.WriteLine("Enter a number: ");
            while (!int.TryParse(Console.ReadLine(), out number) || number <1)
            {
                Console.WriteLine("ERROR");
            }
            return number;
        }
    }
}
