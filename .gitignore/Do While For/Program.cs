using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            int repeat;
            Console.Write("Enter a number: ");
            repeat = int.Parse(Console.ReadLine());

            for (int count = 1; count <= repeat; count++)
            {
                Console.WriteLine("Hello Word " + count);
            }

          
                // for loop example
                Console.WriteLine("For Loop Example!");
                int input, sum = 0, counter = 0;
                Console.WriteLine("Enter a positive number between 1 and 10: ");
                input = int.Parse(Console.ReadLine());
            if (input > 0 && input < 11)
            {

                for (int i = 1; i <= input; i++)
                {
                    Console.WriteLine($"The result of {input} to the power of {i} is {Math.Pow(input, i)} .");
                    // what do you want to do? Sum up all of them
                    sum = sum + (int)Math.Pow(input, i);

                    Console.WriteLine("The sum is " + sum);
                }
                sum = 0;
                //while loop
                Console.WriteLine("While Loop Example!");
                while (counter <= input)
                {
                    Console.WriteLine($" The result of {input} to the power of {counter + 1 } is {Math.Pow(input, counter + 1)} ."); counter++;
                    sum += (int)Math.Pow(input, counter);

                    Console.WriteLine("The sum is " + sum);
                }
                //do while loop version
                counter = 0; sum = 0;
                Console.WriteLine("Do While Loop Version");
                do
                {
                    Console.WriteLine($"The result of {input} to the power of {counter} is {Math.Pow(input, counter)}. ");
                    counter++;
                    sum += (int)Math.Pow(input, counter);
                    Console.WriteLine("The sum is " + sum);
                    //counter = counter + 1 != counter+1, counter++ == counter+= 1;
                } while (counter <= input);
            }
            else
                Console.WriteLine("Invalid Number!");

            Console.ReadLine();
        }
    }
}
