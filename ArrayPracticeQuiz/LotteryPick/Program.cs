using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotteryPick
{
    class Program
    {
        static void Main(string[] args)
        {
            int min, max, quantity;
            Random rnd = new Random();

            Console.WriteLine("Enter number of lottery numbers to generate: ");
            quantity = int.Parse(Console.ReadLine());
            Console.Write("Enter minimum number to generate: ");
            min = int.Parse(Console.ReadLine());
            Console.Write("Enter maximum number to generate: ");
            max = int.Parse(Console.ReadLine());

            int[] lotteryPicks = new int[quantity];

            for (int i = 0; i < quantity; i++)
            {
                lotteryPicks[i] = rnd.Next(min, max + 1);

                Console.WriteLine(Array.IndexOf(lotteryPicks, lotteryPicks[i]));
                

                //true = + 1 index, false = -1 index
                while (Array.IndexOf(lotteryPicks, lotteryPicks[i]) < i)
                {
                    lotteryPicks[i] = rnd.Next(min, max + 1);
                }
                


            }

            Array.Sort(lotteryPicks);
            Console.WriteLine("Your lottery pick are: ");
            for (int i = 0; i < quantity; i++)
            {
                Console.Write(lotteryPicks[i] + " ");
            }

            Console.ReadKey();
        }
    }
}
