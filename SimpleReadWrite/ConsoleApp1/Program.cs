using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter writer = new StreamWriter("loop-test.txt");
            string input="";

            Console.WriteLine("Enter some text. Enter ESC to stop. You can hit enter between lines.");
            do
            {
                input = Console.ReadLine().ToUpper();

                if(input.Equals("ESC"))
                {
                    writer.WriteLine(input);
                }

            } while (!input.Equals("ESC"));
            writer.Close();

            StreamReader reader = new StreamReader("loop-test.txt");

            string line = "";
            while( line!= null)
            {
                line = reader.ReadLine();
                if(line !=null)
                {
                    Console.WriteLine(line);
                }
               
            }
            reader.Close();

            Console.ReadKey();
        }
    }
}
