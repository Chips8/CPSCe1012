using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerSystem
{
    class Player
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int JerseyNumber { get; set; }
        public int Goals { get; set; }
        public DateTime DateOfBirth { get; set; }

        //constructor/default values
        //Constructor has to be the name of your class

        public Player()
        {
            FirstName = "Fill me in";
            LastName = "Empty";
            JerseyNumber = 0;
            Goals = 0;
        }
    }
}
