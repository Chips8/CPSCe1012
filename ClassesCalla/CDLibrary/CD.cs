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

        //properties
        public string Title
        {
            get { return title;}
            set { title = value; } //generic variable that holds the information in
        }
        public string Artist
        {
            get { return artist; }
            set { artist = value; } //generic variable that holds the information in
        }
        public string Genre
        {
            get { return genre; }
            set { genre = value; } //generic variable that holds the information in
        }
        public int NumOfSongs
        {
            get { return numOfSongs; }
            set { numOfSongs = value; } //generic variable that holds the information in
        }
        public bool ExplicitAdvisory
        {
            get { return explicitAdvisory; }
            set { explicitAdvisory = value; } //generic variable that holds the information in
        }

    }
}
