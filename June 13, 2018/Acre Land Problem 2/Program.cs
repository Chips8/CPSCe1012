using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acre_Land_Problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            double acres = 0;
            bool quit = false;
            do
            {
                input = PromptUser();
                if (input.ToUpper() == "X")
                {
                    quit = true;
                }
                else
                {
                    acres = ConvertToAcres(int.Parse(input));
                    Console.WriteLine($"There are {acres:N4} acres in {input} square feet.");
                }
            } while (quit == false);

            Console.WriteLine("Thanks for playing.");
            Console.ReadKey();
        }
        public static double ConvertToAcres(int squareFeet)
        {
            const int SQFT_IN_ACRES = 43560;

            return (squareFeet / (SQFT_IN_ACRES * 1.0));
            // Int divided by an int will lose it's decimal places. Multiplying an int by a decimal forces it into a double.
        }
        static string PromptUser()
        {
            string input = "";
            int number = 0;
            Console.Write("Enter the number of square feet or X to quit: ");
            bool valid = false;

            while( valid == false)
            {
                
                input = Console.ReadLine();

                if(input.ToUpper() == "X")
                {
                    valid = true;
                }
                else
                {

                    if(int.TryParse(input, out number) == true && number > 0)
                    {
                        valid = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input.");
                        Console.Write("Enter the number of square feet or X to quit: ");
                    }
                }
            }

            return input;
        }

    }
}
