using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace July_9__2018
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array Problems 2
            int count = 0;
            int diceRange = 6;
            int[] dice = new int[10];
            Random rdm = new Random();
            for (count = 0; count < diceRange; count++)
            {
                dice[count] = rdm.Next(1, 7);
            }

            count = 0;
            while(count < diceRange-1)
            {
                while (dice[count] == dice[count + 1])
                {
                    dice[count+1] = rdm.Next(1, 7);
                }
                count++;
            }
            for (count = 0; count < diceRange; count++)
            {

                Console.Write(dice[count] + " ");
            }
            Console.ReadKey();
        }
    }
}
