using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Day4_SecE4
    {
        public static void Main()
        {
            //E4 whether it is a perfect number
            //6 = 3 2 1
            Console.Write("Number: ");
            string num = Console.ReadLine();
            int n = Convert.ToInt32(num);
            int sum = 0;

            for (int k = 1; k <= n-1; k++)
            {
                    if (n % k == 0)
                        sum = k + sum;
            }

            if (sum == n)
                Console.WriteLine("{0} is a perfect number.", n);
            else
                Console.WriteLine("{0} is not a perfect number.", n);
        }
    }
}
