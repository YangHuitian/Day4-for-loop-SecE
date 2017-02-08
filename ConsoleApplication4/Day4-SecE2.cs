using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Day4_SecE2
    {
        public static void Main()
        {
            //2
            Console.WriteLine("NO\tINVERSE\tSQUARE ROOT\tSQUARE");
            for (double n = 1.0; n <=10.0; n++)
            {
                double inv = 1 / n;
                double sqrt = Math.Sqrt(n);
                double sq = Math.Pow(n,2);
                Console.WriteLine("{0:0.0}\t{1:0.0##}\t{2:0.0##}\t\t{3:0.0##}", n, inv, sqrt, sq);
            }
            

            //E3 is in Day4-for loop
        }
    }
}
