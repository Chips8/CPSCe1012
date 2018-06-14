using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_Problems_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0, generated = 0, guessCount = 0;

            Random rnd = new Random();
            bool winner = false;
            generated = rnd.Next(1, 101);

            do
            {
                Console.Write("Enter your guess from 1 to 100");
                input = int.Parse(Console.ReadLine());
                guessCount++;

                if(generated == input)
                {
                    Console.WriteLine("You Win");
                    winner = true;

                }
                else
                {
                    if (input < generated)
                    {
                        Console.WriteLine("Too Low");
                    }
                    else
                    {
                        Console.WriteLine("Too High");
                    }
                }




            } while (winner == false);
            Console.WriteLine($"You win, it took {guessCount} tries!");
            Console.ReadKey();
        }
    }
}
