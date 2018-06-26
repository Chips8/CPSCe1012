using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Return_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = GetSafeInt("Enter a number ", "Invalid message", 1, 100);
            Console.WriteLine("You entered: " + num);
            Console.ReadKey();
        }
        static int GetSafeInt(string prompt, string error, int min, int max)
        {
            Console.WriteLine($"{prompt} Min: {min} Max: {max}");           
            int number;
            while(int.TryParse(Console.ReadLine(), out number) == false || number < min || number >= max)
            {
                Console.WriteLine(error);
                Console.WriteLine($"{prompt} Min: {min} Max: {max}");
            }
            return number;

        }
    }
}
