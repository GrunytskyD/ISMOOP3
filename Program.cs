using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            double value = 15.10;
            var fr1 = Fraction.ToFraction(10.10);
            var fr2 = Fraction.ToFraction(2.4);
            Console.WriteLine((fr1 + fr2).ToDouble());
            Console.WriteLine((fr1 - fr2).ToDouble());
            Console.WriteLine((fr1 * fr2).ToDouble());
            Console.WriteLine((fr1 == fr2));
            Console.WriteLine((fr1 != fr2));
        }
    }
}
