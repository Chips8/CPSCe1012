using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Km_to_Miles_Convertor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare Variables
            double distanceKm, distanceMiles;



            Console.WriteLine("Enter the distance in kilometers (km).");
            distanceKm = double.Parse(Console.ReadLine());

            distanceMiles = distanceKm * 0.631371;

            Console.WriteLine($"The distance in miles is: {distanceMiles} miles");
            Console.ReadLine();

          



            
        }
    }
}
