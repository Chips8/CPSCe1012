using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.Write("Enter a number: ");

            try
            {
                number = int.Parse(Console.ReadLine());
                Console.WriteLine("You entered " + number);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Sorry that was not a number. ");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("This should execute no matter what");
            }
            Console.ReadKey();
        }
    }
}
