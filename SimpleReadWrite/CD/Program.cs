using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
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


         
            StreamWriter writer = null;
            string path = "C:\\Users\\cwong54\\desktop\\objectReadWrite.txt";
            try
            {
                writer = new StreamWriter(path);
                //write every CD in array to file
                for (int i = 0; i < 20; i++)
                {
                    writer.WriteLine(i + 1 + "," + cdLibrary[i].Artist+ "," + cdLibrary[i].Title + "," + cdLibrary[i].NumOfSongs + "," + cdLibrary[i].Genre + "," + cdLibrary[i].ExplicitAdvisory);
                    //stuck with encantination
                }
                //easier to reaference
                //ID, artist title, numOfSongs, genre, advisory
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if(writer != null)
                {
                    writer.Close();
                }
            }

            //we have to wipe out array
            Array.Clear(cdLibrary,0, cdLibrary.Length);
            StreamReader reader = null;
            try
            {
                reader = new StreamReader(path);
                while (!reader.EndOfStream)
                {
                    string currentLine = reader.ReadLine();
                    string[] lineArray = currentLine.Split(',');
                    CD tempCD = new CD();

                    tempCD.Artist = lineArray[1];
                    tempCD.Title = lineArray[2];
                    tempCD.NumOfSongs = int.Parse(lineArray[3]);
                    //doesn't know it is an int. Need to parse it
                    tempCD.Genre = lineArray[4];
                    tempCD.ExplicitAdvisory = bool.Parse(lineArray[5]);
                    //cannot conver string to bool
                    //dont wanna throw it, so save it back into array

                    cdLibrary[int.Parse(lineArray[0]) - 1] = tempCD;
                }

            }
            //must create constructor to pass in everything we need and see newCd and pass it in in once shot
            //manually create each one and create each property, some times you need to create and add so use overloaded
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }
            Console.WriteLine("\n read in data");
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(cdLibrary[i].Artist);
                Console.WriteLine(cdLibrary[i].Title);
                Console.WriteLine(cdLibrary[i].NumOfSongs);
                Console.WriteLine(cdLibrary[i].ExplicitAdvisory);
                Console.WriteLine(cdLibrary[i].Genre);
            }
            //split string into an array and do what we want with it

            //set path to desktop
            Console.ReadKey();
        }
    }
}
