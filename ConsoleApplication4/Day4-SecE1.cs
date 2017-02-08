using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Day4_SecE1
    {
        public static void Main()
        {
            //E1 (a)
            //Console.Write("Number: ");
            //string num = Console.ReadLine();
            //int n = Convert.ToInt32(num);
            //int answer = 1;

            //for (int i = 2; i <= n; i++)
            //{
            //    answer = i * answer;
            //}
            //Console.WriteLine(answer);


            //E1 (b)
            Console.Write("Number: ");
            string num = Console.ReadLine();
            int n = Convert.ToInt32(num);
            int answer = 1;

            for (int i = n; i >= 2; i--)
            {
                answer = i * answer;
            }
            Console.WriteLine(answer);


        }
    }
}
