using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overload
{
    class Program
    {
        static void Main(string[] args)
        {
            int menu = 0;
            const decimal GST = 0.05m;
            decimal subtotal = 0, tax = 0, total = 0;
            menu = GetMenuChoice();
            subtotal = GetSubtotal();


            switch(menu)
            {
                case 1:
                    tax = CalculateTax(subtotal, GST);
                    break;
                case 2:
                    tax = CalculateTax(subtotal, GST, 0.07m);
                    break;
                case 3:
                    tax = CalculateTax(subtotal, GST, 0.08m);
                    break;
                case 4:
                    tax = CalculateTax(subtotal, GST, 0.10m);
                    break;
            }
            total = subtotal + tax;
            Console.WriteLine($"{"Subtotal",-15}{subtotal,5:C2}");
            Console.WriteLine($"{"Tax",-15}{tax,5:C2}");
            Console.WriteLine($"{"Total",-15}{total,5:C2}");
            Console.ReadKey();

        }
        public static decimal GetSubtotal()
        {
            decimal temp;
            Console.Write("Enter a price: ");
            while(decimal.TryParse(Console.ReadLine(), out temp) == false || temp <= 0)
            {
                Console.WriteLine("Invalid price! Try again!");
                Console.Write("Enter a price: ");
            }
            return temp;
        }
        public static void DisplayMenu()
        {
            Console.WriteLine("1. Alberta");
            Console.WriteLine("2. BC");
            Console.WriteLine("3. Ontario");
            Console.WriteLine("4. Nova Scotia");
        }
        public static int GetMenuChoice()
        {
            int menu;
            DisplayMenu();
            while(!int.TryParse(Console.ReadLine(), out menu) || menu < 1 || menu > 4)
            {
                Console.WriteLine("Error invalid menu option.");
                DisplayMenu();
            }
            return menu;
        }
        public static decimal CalculateTax(decimal subtotal, decimal tax1)
        {
            return subtotal * tax1;
        }
        public static decimal CalculateTax(decimal subtotal, decimal tax1, decimal tax2)
        {
            return subtotal * tax1 + (subtotal * tax2);
        }

    }
}
