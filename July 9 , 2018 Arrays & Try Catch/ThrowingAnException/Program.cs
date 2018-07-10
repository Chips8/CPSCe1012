using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThrowingAnException
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5, num2 = 0;

            //for a little more control
            try
            {
                if (num2 == 0)
                {
                    //flexibility in our error messages, to overwrite ex.Message!
                    throw new Exception("Cannot divide by 0");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            Console.ReadKey();

        }
    }
}
