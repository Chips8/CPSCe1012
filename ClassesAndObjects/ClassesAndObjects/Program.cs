using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 /*
 * ---------------------------------------|
 * |               Package                |
 * |--------------------------------------|
 * | + width: double                      |
 * | + length: double                     |
 * | + height: double                     |
 * |--------------------------------------|
 * | + GetVolume(): double                |
 * | + GetSurfaceArea(): double           |
 * |--------------------------------------|
 * 
 * 
 * 
 * 
 */


namespace ClassesAndObjects
{
    class Program
    {
       static void Main(string[] args)
        {
            package myPkg = new package();
            myPkg.Height = GetNumber();
            myPkg.Length = GetNumber();
            myPkg.Width = GetNumber();


            Console.WriteLine("The volume of the package is: " + myPkg.GetVolume() + " and the surface area is " + myPkg.GetSurfaceArea());


        }
        static int GetNumber()
        {
            int number;
            Console.Write("Enter a number: ");
            while(int.TryParse(Console.ReadLine(), out number) == false || number < 1)
            {
                Console.WriteLine("Invalid Number, please Try again");
            }
            return number;
        }
    }
}
