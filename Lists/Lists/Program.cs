using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[5];
            names[0] = "Bob";
            names[1] = "Tom";
            names[2] = "Sue";
            names[3] = "Anne";
            names[4] = "Fred";

            //Play more than one game at a time
            Array.Sort(names);
            //Re-organzied all the names in the arrays

            //By default it would be ascending offer
            Console.WriteLine(names[2]);

            //Don't rely on what you hard coded, because now it overwrote Fred, not Sue
            names[2] = "Mary";

            //find sue
            for (int i = 0; i < 5; i++)
            {
                if (names[i].Equals("Sue"))
                {
                    Console.WriteLine("Found Sue at " + i);
                }
                // == works great for numbers, .Equals is best for texts
            }
            // Let's make a list
            List<string> nameList = new List<string>();
            // Does not need a fixed size

            nameList.Add("Bob");
            nameList.Add("Tom");
            nameList.Add("Sue");
            nameList.Add("Anne");
            nameList.Add("Fred");
            
            // with our add item, there is no overload, so we have to add it singularily

            nameList.Sort();
            //Can still use loops, List is an array, don't forget that, it just has more versatility.
            //Index numbers still exist, even though we don't see it

            foreach(var item in nameList)
            {
                Console.WriteLine(item);
            }
            nameList[0] = "George";

            //insert Albert as a second name
            nameList.Insert(1, "Albert");
            
            //remove all strings assigned as "Fred"
            nameList.Remove("Fred");

            // remove george at a specific location
            nameList.RemoveAt(0);

            if(nameList.Contains("Tom"))
            {
                Console.WriteLine("Found Tom");
            }
            //There is a method for case insensitivity searching

            List<int> numberList = new List<int>();

            //List.Count to do all the average

            //Prompt numbers from user (10 max)


            //Think a different way, instead of using a while
            for (int count = 0; count < 10; count++)
            {
                int input;

                Console.WriteLine("Enter a number");
                if(int.TryParse(Console.ReadLine(), out input) == true)
                {
                    numberList.Add(input);
                }
                else
                {
                    Console.WriteLine("That wasn't a number. Try again");
                    count--;
                }
            }

            Console.WriteLine("Sum of the numbers is " + numberList.Sum());
            Console.WriteLine("Average of the numbers is " + numberList.Average());
            Console.WriteLine("There are " + numberList.Count + "numbers in the list");
            //Count is not a method
        }
    }
}
