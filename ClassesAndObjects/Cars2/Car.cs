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
        public string Colour { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Mileage { get; set; }
        public bool HeatedSeats { get; set; }
        //One of the main reasons of a constructor is to set a default value


        //Constructor - setting a default Make
        public Car()
        {
            this.Make = "Chev";
        }
        //Overloaded constructor - if have all pieces of information can create object with values instead of creating object and then setting values
        public Car(string _make, string _model, string _colour, bool _heatedSeats, int _mileage)
        {
            Make = _make;
            Model = _model;
            Colour = _colour;
            HeatedSeats = _heatedSeats;
            Mileage = _mileage;
        }
    }
}
