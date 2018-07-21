using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            char menu;
            const int MAX_PLAYERS = 23;
            int count = 0;

            Player[] playerArray = new Player[MAX_PLAYERS];
            // difference between logical and physical size, logical how much stuff got put into it.

            do
            {
                menu = GetMenuChoice();
                switch(menu)
                {
                    case 'C':
                        CreatePlayer(playerArray, ref count);
                        break;
                    case 'L':
                        ListPlayers(playerArray, count);
                        break;
                    default:
                        break;
                }

            } while (menu != 'Q');
            Console.ReadKey();
        }
        static void ListPlayers(Player[] playerArray, int count)
        {

            if (count == 0)
            {
                Console.WriteLine("Please add players first!");
            }
            else
            {
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine($"{playerArray[i].FirstName, 20}{playerArray[i].LastName, 20} {playerArray[i].JerseyNumber, 10}{playerArray[i].Goals, 10}{playerArray[i].DateOfBirth.ToShortDateString(), 15}");
                }
            }
        }
        static void CreatePlayer(Player[] playerArray, ref int count)
        {
            Player currentPlayer = new Player();
            Console.Write("Enter players first name: ");
            currentPlayer.FirstName = Console.ReadLine();

            Console.Write("Enter players last name: ");
            currentPlayer.LastName = Console.ReadLine();

            currentPlayer.JerseyNumber = GetValidInt("Enter the jersey number: ");
            currentPlayer.Goals = GetValidInt("Enter number of goals: ");
            // not saved any where atm

            //saves it into the array
            playerArray[count] = currentPlayer;
            count++;
            
        }
        
        static int GetValidInt(string prompt)
        {
            int num;
            Console.WriteLine(prompt);
            while (int.TryParse(Console.ReadLine(), out num) == false || num < 0)
            {
                Console.WriteLine("Error. Invalid Number!");
                Console.WriteLine(prompt);
            }
            return num;
        }
        static void DisplayMenu()
        {
            Console.WriteLine("Player System");
            Console.WriteLine("C - Create a player");
            Console.WriteLine("L - List players");
            Console.WriteLine("Q - Quit");
            Console.Write("Enter your choice: ");
        }
        static char GetMenuChoice()
        {
            char menu;
            DisplayMenu();
            while(char.TryParse(Console.ReadLine().ToUpper(), out menu) == false || (menu != 'C' && menu != 'L' && menu != 'Q'))
            {
                Console.WriteLine("Invalid menu choice. Try again!");
                DisplayMenu();
            }
            return menu;
        }
    }
}
