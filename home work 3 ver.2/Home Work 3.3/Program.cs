using System;

namespace домашнее_задание_3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            {
                string greeting = System.Console.ReadLine();

                for (int i = greeting.Length - 1; i >= 0; i--)
                {

                    System.Console.Write(greeting[i]);
                    

                }            
                
            }

        }
    }
}
