using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace In_Class4
{
    class Program
    {
        static void Main(string[] args)
        {

            int length = 4;
            int howMany = 2;
            char letter = '*';
            int spaceBetween = length * 2;
            int count = 0;
            int rowCount = 1;
            do
            {
                if (rowCount == 2 || rowCount == 4)
                {
                    Console.Write("".PadLeft(length));
                }
                if (rowCount == 3)
                {
                    Console.Write("".PadLeft(spaceBetween));
                }
                while (count < howMany)
                {
                    for (int i = 0; i < length; i++)
                    {
                        Console.Write(letter);
                    }
                    Console.Write(" ".PadLeft(spaceBetween));
                    count++;
                }
                Console.WriteLine();
                rowCount++;
                count = 0;
            } while (rowCount <= 5);
            
            Console.ReadKey();
        }
    }
}
