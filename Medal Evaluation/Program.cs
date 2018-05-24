using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medal_Evaluation
{
    class Program
    {
        static void Main(string[] args)
        {
            double score1, score2, score3, gold, bronze, silver;
            string message;

            Console.WriteLine("What is the First score?");
            score1 = double.Parse(Console.ReadLine());

            Console.WriteLine("What is the Second score?");
            score2 = double.Parse(Console.ReadLine());

            Console.WriteLine("What is the Third score?");
            score3 = double.Parse(Console.ReadLine());

            //Decision making

            if (score1 > score2)
            {
                gold = score1;
                silver = score2;
            }

            else

            {
                gold = score2;
                silver = score1;

            }

            if (score3 > gold)
            {
                bronze = silver;
                silver = gold;
                gold = score3;
            }
            else
            {
                if (score3 > silver)
                {
                    bronze = silver;
                    silver = score3;
                }
                bronze = score3;

            }

            Console.WriteLine($"Gold: {gold}, Silver: {silver}, Bronze: {bronze}");
            Console.ReadKey();
        }
    }
}
