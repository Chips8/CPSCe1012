using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars2
{
    class Program
    {
        static void Main(string[] args)
        {
            Car newCar = new Car();

            //this should display Chev
            Console.WriteLine(newCar.Make);

            Car myOtherCar = newCar;

            Car myThirdCar = new Car("Ford", "Mustang", "red", true, 1500);

            Console.ReadKey();

        }
    }
}
