using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                //Random rnd = new Random(); Will cause inconsistent numbers because it is using the same time stamp to generate a number.
                Console.WriteLine(rnd.Next(1, 101));
            }

            Console.ReadKey();
        }
    }
}
