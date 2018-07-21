using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDLibrary
{
    //fully implemented properties
    class CD
    {
        private string title, artist, genre;
        private int numOfSongs;     
        //private string artist;
        private bool explicitAdvisory;

        public string Title
        {
            get
            { return title; }
            set
            {
                //generic variable to store and shuffle value?
                title = value;
            }
        }
        public string Artist
        {
            get { return artist; }
            set { artist = value; }
        }
        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }
        public int NumOfSongs
        {
            get { return numOfSongs; }
            set { numOfSongs = value; }
        }
        public bool ExplicitAdvisory
        {
            get { return explicitAdvisory; }
            //temporary variable to store a value
            set { explicitAdvisory = value; }

        }
    }
}



