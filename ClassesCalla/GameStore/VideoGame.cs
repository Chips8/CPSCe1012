using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//this is all the information that an individual game needs to have.


namespace GameStore
{
    class VideoGame
    {
        public string GameTitle { get; set; }
        public decimal Price { get; set; }
        public long GameCode { get; set; }

        public VideoGame()
        {
            GameTitle = "Untitled";
            Price = 49.98m;
        }
    }
}
