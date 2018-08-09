using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace LoopingMultipleValues
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter writer = null;
            
            try
            {
                writer = new StreamWriter("loop.txt");
                for (int i = 1; i <= 5; i++)
                {
                    Console.WriteLine("FirstName{0}, LastName{0}, ID{0}", i);
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (writer != null)
                {
                    writer.Close();
                }
            }

            StreamReader reader = null;
            string input;
            try
            {
                reader = new StreamReader("loop.txt");
                Console.WriteLine($"{"ID",5} {"Last Name",-20} {"First Name",-20}");
                while (!reader.EndOfStream)
                {
                    input = reader.ReadLine();
                    string[] stringArrary = input.Split(',');
                    Console.WriteLine($"{stringArrary[2],5} {stringArrary[0],-20} {stringArrary[1],-20}");
                    //text file doent know if its number or not
                }
            }
            catch(Exception ex)
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
            Console.ReadKey();
        }
    }
}
