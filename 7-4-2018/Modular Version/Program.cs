using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modular_Version
{
    class Program
    {
        static void Main(string[] args)
        {
           
            const int MAX_SIZE = 5;
            decimal[] prices = new decimal[MAX_SIZE];
            string[] description = new string[MAX_SIZE];
            int[] quantity = new int[MAX_SIZE];
            bool addMore = true;
            decimal subtotal = 0, tax, total;
            string temp;
            int menu;
            int count = 0;

            do
            {

                menu = GetMenuChoice();

                switch(menu)
                {
                    case 1:
                        //add
                        count = AddItem(description, prices, quantity, count);
                        Console.WriteLine("Item added successfully");
                        break;
                    case 2:
                        //edit
                        break;
                    case 3:
                        //display
                        DisplayAll(description, prices, quantity, count);
                        CalculateFinancials(prices, quantity, count, out subtotal, out tax, out total);
                        DisplayFinancials(subtotal, tax, total);
                        // Has to have an out if out is used in method.
                        break;
                    case 4:
                        //exit
                        addMore = false;
                        Console.WriteLine("Thanks for playing, good bye");
                        break;

                }
            } while (addMore == true);

        }
        public static void DisplayMenu()
        {
            Console.WriteLine("1. Add Item");
            Console.WriteLine("2. Edit Item");
            Console.WriteLine("3. Display Items");
            Console.WriteLine("4. Quit");
            Console.Write("Enter the Number: ");
        }
        public static int GetMenuChoice()
        {

            int menuChoice = 0;
            DisplayMenu();
            while (!int.TryParse(Console.ReadLine(), out menuChoice)|| menuChoice < 1 || menuChoice > 4)
            {
                Console.WriteLine("Invalid Menu Option. Try Again");
                DisplayMenu();
            }

            return menuChoice;
        }
        //AddItem = description, prices, quantity, count
        public static int AddItem(string[] description, decimal[] prices, int[] quantity, int count)
        {
            Console.Write($"Enter a description # {count + 1}: ");
            description[count] = Console.ReadLine();

            Console.Write($"Enter price #{count + 1}: ");
            prices[count] = decimal.Parse(Console.ReadLine());
            
            Console.Write($"Enter a quantity #{count + 1}: ");
            quantity[count] = int.Parse(Console.ReadLine());
            count++;

            return count;
        }
        static void DisplayAll(string[] description, decimal[] prices, int[] quantity, int count)
        {
            if(count > 0)
            {
                Console.WriteLine("{0,5}{1,-50}{2,10}{3,10}{4,10}", "ID", "Description", "Qty", "$ per", "Total");
                for (int index = 0; index < count; index++)
                {
                    Console.WriteLine("{0,5}{1,-50}{2,10}{3,10}{4,10:c2}",index+1, description[index], quantity[index], prices[index], prices[index], quantity[index] * prices[index]);
                }
            }
            else
            {
                Console.WriteLine("Nothing to display!");
            }
        }
        //Bi-ref and out
        public static void CalculateFinancials(decimal[] prices, int[] quantity, int count, out decimal subtotal, out decimal tax, out decimal total)
        {
            const decimal TAX_PERCENT = 0.05m;
            subtotal = 0;
            for (int i = 0; i < count; i++)
            {
                subtotal += prices[i] * quantity[i];
            }
            tax = subtotal * TAX_PERCENT;
            total = subtotal + tax;
        }
        public static void EditItem(string[] description, decimal[] prices, int[] quantity, int choice)
        {
            string temp;
            choice--;
            Console.WriteLine("Existing description: " + description[choice]);
            Console.WriteLine("Enter a new description or enter to keep exisitng: ");
            temp = Console.ReadLine();
            if (!temp.Equals(""))
            {
                description[choice] = temp;
            }
            Console.WriteLine("Exisitng Price:" + prices[choice]);
            Console.Write("Enter a new price or enter to keep existing: ");
            temp = Console.ReadLine();
            if (!temp.Equals("") && decimal.TryParse(temp, out prices[choice]) == false )
            {
                prices[choice] = decimal.Parse(temp);
            }
            Console.WriteLine("Exisitng Price:" + quantity[choice]);
            Console.Write("Enter a new price or enter to keep existing: ");
            temp = Console.ReadLine();
            if (!temp.Equals(""))
            {
               quantity[choice] = int.Parse(temp);
            }

        }
        public static void DisplayFinancials(decimal subtotal, decimal tax, decimal total)
        {
            for (int i = 0; i < 85; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
            Console.WriteLine("{0, -70} {1, 10:C2}", "Subtotal: ", subtotal);
            Console.WriteLine("{0, -70} {1, 10:C2}", "Tax: ", tax);
            Console.WriteLine("{0, -70} {1, 10:C2}", "Total: ", total); // 0 means the 1st item to be stored.

        }
        
    }
}
