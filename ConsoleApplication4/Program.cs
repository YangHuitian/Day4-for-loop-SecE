using System;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Bank of ISS");
            string cocode = "654321";
            bool yourcode = false;
            int t = 0;

            while (!yourcode)
            {
                t += 1;//t++ will also work
                Console.Write("Enter your PIN: ");
                string code = Console.ReadLine();

                if (code == cocode)
                {
                    yourcode = true;
                    Console.WriteLine("PIN accepted. You can access your account now.");
                }
                else
                {
                    if (t == 3)
                    {
                        yourcode = true;
                        Console.WriteLine("Too many wrong PIN entries. Your account is now locked.");
                    }
                    else
                    {
                        yourcode = false;
                        Console.WriteLine("Incorrect PIN. Pls try again.");
                    }
                }
            }



            






        }
    }
}
