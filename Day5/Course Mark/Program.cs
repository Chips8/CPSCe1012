using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Mark
{
    class Program
    {
        static void Main(string[] args)
        {
            double exercise, corePortfolio, quiz, advancedPortfolio, totalPercentage;


            Console.WriteLine("Enter your Exercise mark in percentage (%)");
            exercise = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter your corePortfolio mark in percentage (%)");
            corePortfolio = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter your Quiz mark in percentage (%)");
            quiz = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter your advancedPortfolio mark in percentage (%)");
            advancedPortfolio = double.Parse(Console.ReadLine());

            totalPercentage = ((exercise * 0.15) + (corePortfolio * 0.2) + (quiz * 0.2) + (advancedPortfolio * 0.45))/100.0;

            Console.WriteLine($"Your total Course mark in percentage (%) is {totalPercentage:p}");
            Console.ReadLine();
        


        }
    }
}
