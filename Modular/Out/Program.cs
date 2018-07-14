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
            //to use out the variable cannot have an initial value. It is not passed into the method - just used to get something out.
            int menu;
            const decimal GST = 0.05m;
            decimal subtotal, tax = 0 , total;            
            GetMenuChoice(out menu);
            GetSubtotal(out subtotal);


            switch (menu)
            {
                case 1:
                    CalculateTax(subtotal, GST, out tax);
                    break;
                case 2:
                    CalculateTax(subtotal, GST, 0.07m, out tax);
                    break;
                case 3:
                    CalculateTax(subtotal, GST, 0.08m, out tax);
                    break;
                case 4:
                    CalculateTax(subtotal, GST, 0.10m, out tax);
                    break;
            }

            total = subtotal + tax;
            Console.WriteLine($"{"Subtotal",-15}{subtotal,5:C2}");
            Console.WriteLine($"{"Tax",-15}{tax,5:C2}");
            Console.WriteLine($"{"Total",-15}{total,5:C2}");
            Console.ReadKey();

        }
        public static void GetSubtotal(out decimal subtotal)
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
        public static void GetMenuChoice(out int menuOption)
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
        public static void CalculateTax(decimal subtotal, decimal tax1, out decimal tax)
        {
            tax = subtotal * tax1;
        }
        public static void CalculateTax(decimal subtotal, decimal tax1, decimal tax2, out decimal tax)
        {
            tax = subtotal * tax1 + (subtotal * tax2);
        }

    }
}