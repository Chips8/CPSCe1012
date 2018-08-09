using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace SimpleReadWrite
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter writer = new StreamWriter("test.txt");
            //use null for try catch

            writer.WriteLine("Hello! Files are fun!");
            writer.Close();
            //StreamWriter is to write
            //StreamReader is to read
            //IO library allows us to access everything in there
            //Where does it create the file?
            //release folder instead of debug folder
            //make sure to close text file before run program

            StreamReader reader = new StreamReader("test.txt");

            Console.WriteLine(reader.ReadLine());
            Console.ReadLine();
        }
    }
}
