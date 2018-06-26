using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateSalesByUnit
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        static int CaclculateSalesByUnit(int sales, double percent)
        {
            return (int)(sales * (percent / 100));
            // is this best practice?
            //no it is not, use method to get a decimal and use the main to determine what to do with the decimal
            
        }
    }
}
