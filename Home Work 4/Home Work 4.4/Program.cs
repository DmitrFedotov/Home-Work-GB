using System;

namespace Home_Work_4
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 1024; i++)
            {
                Console.WriteLine(Fib(i));
            }
           
        }
        static long Fib(int n)
        {
            if (n < 3)
                return 1;
            else
                return Fib(n - 2) + Fib(n - 1);
        }
    }
}
