using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            CD[] cdLibrary = new CD[20];
            Random rdm = new Random();
            for (int i = 0; i < 20; i++)
            {
                cdLibrary[i] = new CD();
            }
            //get
            cdLibrary[0].Artist = "The tragically hip";
            cdLibrary[0].Title = "Road Apples";
            cdLibrary[0].NumOfSongs = 14;
            cdLibrary[0].ExplicitAdvisory = false;
            cdLibrary[0].Genre = "Rock";

            //There is a tool to track get and set errors?


            //set
            Console.WriteLine(cdLibrary[0].Artist);
            Console.WriteLine(cdLibrary[0].Title);
            Console.WriteLine(cdLibrary[0].NumOfSongs);
            Console.WriteLine(cdLibrary[0].ExplicitAdvisory);
            Console.WriteLine(cdLibrary[0].Genre);


            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(cdLibrary[i].Artist);
                Console.WriteLine(cdLibrary[i].Title);
                Console.WriteLine(cdLibrary[i].NumOfSongs);
                Console.WriteLine(cdLibrary[i].ExplicitAdvisory);
                Console.WriteLine(cdLibrary[i].Genre);
            }

            Console.ReadKey();
        }
    }
}
