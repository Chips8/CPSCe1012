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

        //constructor
        public Player()
        {
            FirstName = "Fill me in!";
            LastName = "empty";
            JerseyNumber = 0;
            Goals = 0;
        }
    }
}
