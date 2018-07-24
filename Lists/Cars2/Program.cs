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
            try
            {
                Car newCar = new Car();

                //this should display Chev
                Console.WriteLine(newCar.Make);

                Car myOtherCar = newCar;


                Car myThirdCar = new Car("Ford", "Mustang", "red", true, 1500, 2050);

                Console.WriteLine("My current speed is " + myThirdCar.Speed);

                myThirdCar.Accelerate(20);

                Console.WriteLine("My current speed is " + myThirdCar.Speed);

                myThirdCar.Accelerate(30);

                Console.WriteLine("My current speed is " + myThirdCar.Speed);
                
                myThirdCar.Honk(2);

                // Speed of one is not the speed of another

            }
            catch( Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            //interaction with stuff is in the program

            Console.ReadKey();

        }
    }
}
