using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_Problemz_June_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            int sum = 0;
            int squareNums = 1;
            string message = "";

            Console.WriteLine("Input a Number");
            input = int.Parse(Console.ReadLine());



            for (int count = 1; count <= input; count++)
            {

                sum += squareNums * squareNums;
                //sum = sum + ( squareNums * sqaureNums )
                message += squareNums + " x " + squareNums;
                squareNums++;
                if(count < input)
                {
                    message += " + ";
                }
            }

            //message = message.Trim('+');
            Console.WriteLine(message + " = " + sum);

            Console.ReadKey();
        }
    }
}
