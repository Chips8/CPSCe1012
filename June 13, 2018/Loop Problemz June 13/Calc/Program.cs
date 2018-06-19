using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            char option;
            double num1, num2, result = 0;
            bool validMenuChosen = true;



            option = GetValidMenuItem();

            // Check before the selection
            Console.Write("Enter a number: ");
            num1 = double.Parse(Console.ReadLine());
            Console.Write("Enter another number: ");
            num2 = double.Parse(Console.ReadLine());



            switch (option)
            // Prompt goes to selection and does not check.
            {
                case 'A':
                    //Addition
                    result = num1 + num2;
                    break;
                case 'S':
                    result = num1 - num2;
                    //Subtraction
                    break;
                case 'M':
                    result = num1 * num2;
                    //Multiply
                    break;
                case 'D':
                    result = num1 / num2;
                    //Divide
                    break;
                default:
                    validMenuChosen = false;
                    break;
            }
            
                Console.WriteLine("The result is " + result + ".");
                Console.ReadKey();
            }

        private static double Addition( double num1, num2 )
        {
            result = num1 + num2;
        }


            Console.ReadLine();

        }

        static void DisplayMenu()
        {
            //Prompt User
            Console.WriteLine("\nA - Addition");
            Console.WriteLine("S - Subtraction");
            Console.WriteLine("M - Multiplication");
            Console.WriteLine("D - Division");

        }
        static char GetValidMenuItem()
        {
            char option;
            Console.Write("Enter your choice ");
            option = char.Parse(Console.ReadLine().ToUpper());

            do
            {
                DisplayMenu();
                Console.Write("Enter your choice ");
                option = char.Parse(Console.ReadLine().ToUpper());
                if (option != 'A' && option != 'D' && option != 'M' && option != 'S')
                {
                    Console.Write("Invalid menu choice.");
                }

            } while (option != 'A' && option != 'D' && option != 'M' && option != 'S');
            return option;
            

        }
    }
}
 

