using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Day4_for_loop
    {
        public static void Main()
        {
            //E3: prime number 
            bool foundFactor = false;
            string input = Console.ReadLine();
            int j = Convert.ToInt32(input);
            for (int i = 2; i <= (j - 1); i++)
            {
                if (j % i == 0)
                {
                    foundFactor = true;
                    //Console.WriteLine(i);//print out all factor
                    //break;// use it when you want to break out
                }
            }

            if (foundFactor == true)
                Console.WriteLine("{0} is not a prime num", j);
            else
                Console.WriteLine("{0} is a prime num", j);
        }
    }
}
