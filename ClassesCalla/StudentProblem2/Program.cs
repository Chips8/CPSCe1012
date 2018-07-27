using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> roster = new List<Student>();
            int menu;
            do
            {
                menu = GetMenu();
                switch (menu)
                {
                    case 1:
                        AddStudent(roster);
                        break;
                    case 2:
                        ViewReport(roster);
                        break;
                }
            } while (menu!=3);
            Console.WriteLine("Oh, okay...you are leaving? Alright. Bye.");
            Console.ReadKey();

        }
        static void DisplayMenu()
        {
            Console.WriteLine("\n1 - Add Student");
            Console.WriteLine("2 - Display roster");
            Console.WriteLine("3 - Quit");
            Console.WriteLine("Enter the number of your choosing: ");

        }
        static int GetMenu()
        {
            DisplayMenu();
            int menuChoice;
            while (!int.TryParse(Console.ReadLine(), out menuChoice) || menuChoice < 1 || menuChoice > 3)
            {
                Console.WriteLine("\nSorry, invalid menu option");
                DisplayMenu();
            }
            return menuChoice;
        }
        static void ViewReport(List<Student> roster)
        {
            Console.WriteLine($"{"Id",-3}{" ",5}{"Last Name",-9}{" ",5}{"First Name",-10}");
            Console.WriteLine($"{"---",-3}{" ",5}{"---------",-9}{" ",5}{"---------",-10}");

            for (int i = 0; i < roster.Count; i++)
            {
                Console.WriteLine($"{roster[i].GetIdNumber(),-3}{" ",5}{roster[i].GetLastName(),-9}{" ",5}{roster[i].GetFirstName(),-10}");
            }
        }
        static void AddStudent(List<Student> roster)
        {
            Student tempStudent = new Student();
            Console.Write("Enter the student's first name: ");
            tempStudent.SetFirstName(Console.ReadLine());
            Console.Write("Enter the student's last name: ");
            tempStudent.SetLastName(Console.ReadLine());
            Console.Write("Enter the id: ");
            tempStudent.SetIdNumber(GetValidId());

            roster.Add(tempStudent); //adds this to the list, don't forget this!
        }
        static int GetValidId()
        {
            int id;
            while (!int.TryParse(Console.ReadLine(), out id) || id < 0)
            {
                Console.WriteLine("\nSorry, invalid id number.");
            }
            return id;
        }
    }
}
