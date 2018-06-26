using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace June_2018
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int minNum = 0;
            int maxNum = 0;
            int diceNum01 = rnd.Next(minNum, maxNum);

            int diceNum02 = rnd.Next(minNum, maxNum);
            while(diceNum02 == diceNum01)
            {
                diceNum02 = rnd.Next(minNum, maxNum);
            }
            int diceNum03 = rnd.Next(minNum, maxNum);
            while (diceNum03 == diceNum01 || diceNum03 == diceNum02)
            {
                diceNum03 = rnd.Next(minNum, maxNum);
            }
            int diceNum04 = rnd.Next(minNum, maxNum);
            while (diceNum04 == diceNum01 || diceNum04 == diceNum02 || diceNum04 == diceNum03)
            {
                diceNum04 = rnd.Next(minNum, maxNum);
            }
            int diceNum05 = rnd.Next(minNum, maxNum);
            while (diceNum05 == diceNum01 || diceNum05 == diceNum02 || diceNum05 == diceNum03 || diceNum05 == diceNum04)
            {
                diceNum05 = rnd.Next(minNum, maxNum);
            }
            int diceNum06 = rnd.Next(minNum, maxNum);
            while (diceNum06 == diceNum01 || diceNum06 == diceNum02 || diceNum06 == diceNum03 || diceNum06 == diceNum04 || diceNum06 == diceNum05)
            {
                diceNum06 = rnd.Next(minNum, maxNum);
            }


        }
    }
}
