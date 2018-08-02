using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int points = 0;
            char menuOption = ' ';
            string prize1, prize2;

            do
            {
                menuOption = GetValidMenuOption();
                ProcessMenuOption(menuOption, ref points);
                

            } while (menuOption != 'X');
            CollectPrizes(points, out prize1, out prize2);
            DisplayPrizes(prize1, prize2);
            Console.ReadKey();


        }
        static void DisplayMenu()
        {
            Console.WriteLine("A - Add Sales");
            Console.WriteLine("B - Point Balance");
            Console.WriteLine("X - Collect Prizes and Quit");
        }
        static char GetValidMenuOption()
        {
            char menu;
            DisplayMenu();
            while(!char.TryParse(Console.ReadLine().ToUpper(), out menu) || (menu != 'A' && menu != 'B' && menu != 'X'))
            {
                Console.WriteLine("Error, only A, B, or X allowed");
                DisplayMenu();
            }
            return menu;
        }
        static void ProcessMenuOption(char menu, ref int points)
        {
            switch(menu)
            {
                case 'A': GetSaleAmountToPoints(ref points);
                    DisplayBalance(points);
                    break;

                case 'B': DisplayBalance(points);
                    break;
                default:
                    break;
            }
        }
        static double GetValidDouble(string prompt)
        {
            double number;
            Console.WriteLine(prompt);
            while(double.TryParse(Console.ReadLine(), out number) == false || number < 0)
            {
                Console.WriteLine("Invalid number, must be positive!");
                Console.WriteLine(prompt);
            }
            return number;
        }
        static void GetSaleAmountToPoints(ref int points)
        {
            double saleAmount = GetValidDouble("Enter sale amount: ");

            if(saleAmount <= 100)
            {
                points += 10;
            }
            else
            {
                if(saleAmount < 200)
                {
                    points += 100;
                }
                else
                {
                    if(saleAmount < 300)
                    {
                        points += 200;
                    }
                    else
                    {
                        points += 300;
                    }
                        
                }
            }
        }
        static void DisplayBalance(int points)
        {
            Console.WriteLine("Your current point balance is: " + points);
        }
        static void CollectPrizes(int point, out string prize1, out string prize2)
        {
            if(point < 100)
            {
                prize1 = "$5 Tim card";
                prize2 = "Bronze pen";
            }
            else
            {
                prize1 = "$15 Tim card";
                prize2 = "Silver pen";
            }

        }
        static void DisplayPrizes(string prize1, string prize2)
        {
            Console.WriteLine("You won a " + prize1 + " and a " + prize2);
        }
    }
}
