using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        static void DisplayMenu()
        {
            Console.WriteLine("1 - Add Student");
            Console.WriteLine("2 - Display roster");
            Console.WriteLine("3 - Quit");
            Console.WriteLine("Enter the number of your choosing: ");
            
        }
        static int GetMenu()
        {
            DisplayMenu();
            int menuChoice;
            if (!int.TryParse(Console.ReadLine(), out menuChoice), || menuChoice< 1 || menuChoice >3)
            {
                Console.WriteLine("Sorry, invalid menu option");
                DisplayMenu();
            }
            return menuChoice;
        }
        static void ViewReport()
        {

        }
        static void AddStudent()
        {

        }
        static int GetValidInt()
        {
            return;
        }


    }
}
