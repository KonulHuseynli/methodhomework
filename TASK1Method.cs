using System;

namespace ConsoleApp26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("include value : ");
            int a = Int32.Parse(Console.ReadLine());
            IsPrime(a);
        }
        static void IsPrime(int a)
        {
            for (int counter = 2; counter < a; counter++)
            {
                if (a % counter == 0  )
                {
                    Console.WriteLine("number is not simple");
                    break;
                }
                else
                {
                    Console.WriteLine("number is simple");
                    break;
                }

            }
        }
    }
}
