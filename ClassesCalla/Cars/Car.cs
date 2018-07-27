using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    class Car
    {
        //shortcut is prop tab tab
        private int year;
        public int Speed { get; set; }
        public string Colour { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Mileage { get; set; }
        public bool HeatedSeats { get; set; }
        public double Price { get; set; }

        //read only property, cannot set the sale price
        public double SalePrice
        {
            get
            {
                return Price * 0.90;
            }
        } //no set

        //default to Chevy, we use a constructor - setting a default Make
        public Car()
        {
            this.Make = "Chevy";
        }
        //overloaded constructor - (if we have all the pieces of information can create object with values, nistead of creating object then setting values).
        //properties equal to passed in variables.
        public Car(string _make, string _model, string _colour, bool _heatedSeats, int _mileage, int _year)
        {
            Make = _make;
            Model = _model;
            Colour = _colour;
            HeatedSeats = _heatedSeats;
            Mileage = _mileage;
            Year = _year;
        }
        
        //lets add a honk method
        public void Honk(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                Console.Beep(1200,200);
                Console.Beep(3200, 200);
                Console.Beep(900, 1200);
                Console.Beep(2000, 600);
            }
        }

        //keep track of how fast we are going. and change our speed
        public void Accelerate(int amount)
        {
            Speed += amount;
        }


        //create private field first
        //private int year;
        //now make property for it
        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                if (value<=DateTime.Now.Year)
                {
                    year = value;
                }
                else
                {
                    throw new Exception("Year must be before or equal to this year. Silly.");  //update program.cswrap it ina  trycatch for this to be displayed.
                }
            }
        }
    }
}
