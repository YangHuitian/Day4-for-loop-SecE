using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Day4_for_loop2
    {
        public static void Main()
        {
            //E5
            //find out prime number from 1 -100
            for (int i = 5; i <= 10000; i++)
            {
                bool yourfound = false;
                for (int j = 2; j <= i - 1; j++)
                {
                    if (i % j == 0)
                    {
                        yourfound = true;
                        break;
                    }
                }

                if (yourfound == false)//if (!yourfound)
                {
                    Console.WriteLine("{0} is a prime number.", i);
                }

            }
        }
    }
}
