using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    class Program
    {
        static void Main(string[] args)
        {
            //you should validate everything for your class. If you don't control the validation in the class.
            //you have to validate. IN YOUR CLASS FILE.
            try
            {
                Car car1 = new Car();
                //this should display Chevy
                Console.WriteLine(car1.Make);

                //we just duplicated car1
                Car car2 = car1;

                //used overloaded constructor
                Car car3 = new Car("Ford", "Mustang", "Red", true, 1500,2017);

                //accelerate the car display current, accelerate, display current, accelerate
                Console.WriteLine($"My current speed is {car3.Speed}");
                car3.Accelerate(20);
                Console.WriteLine($"My current speed is {car3.Speed}");
                car3.Accelerate(30);
                Console.WriteLine($"My current speed is {car3.Speed}"); //this entire code, is in relation to each unique instance

                //the interaction with the class goes in the program
                car3.Honk(2);

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }



            Console.ReadKey();
        }
    }
}
