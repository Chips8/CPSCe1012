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
            //By reference - need to change all method return types to void and remove the return statement.
            int menu = 0;
            const decimal GST = 0.05m;
            decimal subtotal = 0, tax = 0, total = 0;
            GetMenuChoice(ref menu);
            GetSubtotal(ref subtotal);


            switch (menu)
            {
                case 1:
                     CalculateTax(subtotal, GST, ref tax);
                    break;
                case 2:
                    CalculateTax(subtotal, GST, 0.07m, ref tax);
                    break;
                case 3:
                    CalculateTax(subtotal, GST, 0.08m, ref tax);
                    break;
                case 4:
                    CalculateTax(subtotal, GST, 0.10m, ref tax);
                    break;
            }
            total = subtotal + tax;
            Console.WriteLine($"{"Subtotal",-15}{subtotal,5:C2}");
            Console.WriteLine($"{"Tax",-15}{tax,5:C2}");
            Console.WriteLine($"{"Total",-15}{total,5:C2}");
            Console.ReadKey();

        }
        public static void GetSubtotal(ref decimal subtotal)
        {
            decimal temp;
            Console.Write("Enter a price: ");
            while (decimal.TryParse(Console.ReadLine(), out temp) == false || temp <= 0)
            {
                Console.WriteLine("Invalid price! Try again!");
                Console.Write("Enter a price: ");
            }
            //program will always try to update subtotal, so use it once to use less processing power.
            subtotal = temp;
        }
        public static void DisplayMenu()
        {
            Console.WriteLine("1. Alberta");
            Console.WriteLine("2. BC");
            Console.WriteLine("3. Ontario");
            Console.WriteLine("4. Nova Scotia");
        }
        public static void GetMenuChoice(ref int menuOption)
        {
            int menu = 0;
            DisplayMenu();
            while (!int.TryParse(Console.ReadLine(), out menu) || menu < 1 || menu > 4)
            {
                Console.WriteLine("Error invalid menu option.");
                DisplayMenu();
            }
            menuOption = menu;
        }
        public static void CalculateTax(decimal subtotal, decimal tax1, ref decimal tax)
        {
            tax = subtotal * tax1;
        }
        public static void CalculateTax(decimal subtotal, decimal tax1, decimal tax2, ref decimal tax)
        {
            tax = subtotal * tax1 + (subtotal * tax2);
        }

    }
}
