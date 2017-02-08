using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Day4_SecE6
    {
        public static void Main()
        {
            //E6
            //find perfect number from 1-1000
            for (int n=1; n <= 1000; n++)
            {
                int sum = 0;

                for (int k=1; k <= n-1; k++)
                {
                    if (n % k == 0)
                        sum = k + sum;
                }

                if (sum == n)
                    Console.WriteLine("{0} is a perfect number.", n);
                
            }

        }
    }
}
