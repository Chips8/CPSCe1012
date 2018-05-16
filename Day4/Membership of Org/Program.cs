using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Membership_of_Org
{
    class Program
    {
        static void Main(string[] args)
        {
            int honoraryMembers = 78;
            int fellows = 9209;
            int members = 35509;
            int associateMembers = 27909;
            int affiliates = 2372;

            int totalMembers = honoraryMembers + fellows + members + associateMembers + affiliates;

            double fellowsPercentage = fellows / ( totalMembers * 1.0 ); 

            Console.WriteLine($"The total membership of Organization X is {totalMembers}.");
            Console.WriteLine($"The fellows account for {fellowsPercentage:p}.");
            //default p is 2 same as c.
            Console.ReadLine();
        }
    }
}
