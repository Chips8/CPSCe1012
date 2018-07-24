using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars2
{
    class Car
    {
        //prop tab tab is shortcut
        private int year;
        public int Speed { get; set;}
        public string Colour { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Mileage { get; set; }
        public bool HeatedSeats { get; set; }
        //One of the main reasons of a constructor is to set a default value
        public double Price { get; set; }

        //fully implented and automated property

        //Read only property - cannot set the sale price
        public double SalePrice
        {
            get
            {
                return Price * .9;
            }
        }

        public int Year
        {
            get
            {
                return year;
            }
            set
            {// Control which year
                if( value <= DateTime.Now.Year)
                {
                    year = value;
                }
                else
                {
                    throw new Exception("Year must be before or equal to this year");
                }

            }
        }
        //You have to validate everything
        //Validate everything on class

        //Constructor - setting a default Make
        public Car()
        {
            this.Make = "Chev";
        }
        //Overloaded constructor - if have all pieces of information can create object with values instead of creating object and then setting values
        public Car(string _make, string _model, string _colour, bool _heatedSeats, int _mileage, int _year)
        {
            Make = _make;
            Model = _model;
            Colour = _colour;
            HeatedSeats = _heatedSeats;
            Mileage = _mileage;
            year = _year;
        }

        public void Honk(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                Console.Beep(1200, 200);
                Console.Beep(3200, 200);
                Console.Beep(900, 1200);
                Console.Beep(2000, 600);
            }
        }

        public void Accelerate(int amount)
        {
            Speed += amount;
        }
    }
}
