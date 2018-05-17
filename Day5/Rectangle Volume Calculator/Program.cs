using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_Volume_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            double width, length, height, volume;

            Console.WriteLine("What is the width of the rectangular box in meters (m)?");
            width = double.Parse(Console.ReadLine());

            Console.WriteLine("What is the length of the rectangular box in meters (m)?");
            length = double.Parse(Console.ReadLine());

            Console.WriteLine("What is the height of the rectangular box in meters (m)?");
            height = double.Parse(Console.ReadLine());

            volume = width * length * height;

            Console.WriteLine($"The volume of the rectangular box is: {volume} m^3");

            Console.ReadLine();

           



        }
    }
}
