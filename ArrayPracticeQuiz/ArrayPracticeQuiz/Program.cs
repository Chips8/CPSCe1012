using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPracticeQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MAX_BARS = 5;
            int numOfBars;
            Console.WriteLine("How many bars in your chart: ");
            while(int.TryParse(Console.ReadLine(), out numOfBars) == false)
            {
                Console.WriteLine("Invalid Entry!");
                Console.WriteLine("How many bars in your chart: ");
            }


            
            //declaration, default value declaration

            int[] chartValues = new int[MAX_BARS];

            for (int i = 0; i < numOfBars; i++)
            {
                Console.WriteLine("Enter value for bar " + (i+1) + ": ");
                chartValues[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < numOfBars; i++)
            {
                for (int count = 0; count < chartValues[i]; count++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();



        }
    }
}
