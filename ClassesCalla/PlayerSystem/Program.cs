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
            const int MAX_PLAYERS = 23; //physical size
            int count=0; //logical size

            Player[] playerArray = new Player[MAX_PLAYERS];

            do
            {
                menu = GetMenuChoice();
                switch (menu)
                {
                    case 'C':
                        CreatePlayer(playerArray, ref count);

                        break;
                    case 'L':
                        ListPlayers(playerArray, count);
                        break;
                }
            } while (menu != 'Q');
            Console.ReadKey();

        }
        static void ListPlayers(Player[] playerArray, int count)
        {
            if (count ==0)
            {
                Console.WriteLine("Please add players first");
            }
            else
            {
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine($"{playerArray[i].FirstName, 20}{playerArray[i].LastName,20}{playerArray[i].JerseyNumber,10}{playerArray[i].Goals,10}{playerArray[i].DateOfBirth,20:short}");
                }
            }

            
        }
        static void CreatePlayer(Player[] playerArray, ref int count)
        {
            //manual way, we could use an overloaded constructor instead
            //create object first
            Player currentPlayer = new Player();
            Console.Write("Enter player's first name: ");
            currentPlayer.FirstName = Console.ReadLine();
            Console.Write("Enter player's last name: ");
            currentPlayer.LastName = Console.ReadLine();
            
            currentPlayer.JerseyNumber = GetValidInteger("Enter player's jersey number: ");
            currentPlayer.Goals = GetValidInteger("Enter player's goal count: ");
            
            //put object in the array
            playerArray[count] = currentPlayer;
            
            //increment
            count++;           
        }
        static DateTime GetValidDate(string prompt)
        {
            DateTime date;
            Console.WriteLine(prompt);
            while (!DateTime.TryParse(Console.ReadLine(), out date))
            {
                Console.WriteLine("Error. Invalid Number");
                Console.Write(prompt);
            }
            return date;
        }
        static int GetValidInteger(string prompt)
        {
            int num;
            Console.Write(prompt);
            while (!int.TryParse(Console.ReadLine(), out num) || num<0)
            {
                Console.Write("Error. Invalid Number");
                Console.Write(prompt);
            }
            return num;
        }
        static void DisplayMenu()
        {
            Console.WriteLine("Player System");
            Console.WriteLine("C - Create a player");
            Console.WriteLine("L - List Players");
            Console.WriteLine("Q - quit");
            Console.WriteLine("Enter your choice");
        }
        static char GetMenuChoice()
        {
            char menu;
            DisplayMenu();
            while (!char.TryParse(Console.ReadLine().ToUpper(), out menu)|| (menu!='C' && menu!='L' && menu!='Q'))
            {
                Console.Write("Invalid Menu Choice");
                DisplayMenu();
            }
            return menu;
        }

            
    }
}
