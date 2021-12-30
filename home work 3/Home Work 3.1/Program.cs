using System;

namespace домашнее_задание_3._1
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] myArray = new int[10 , 10];

            Random random = new Random();

            for (int q = 0; q < myArray.GetLength(0); q++)
            {
                for (int w = 0; w < myArray.GetLength(1); w++)
                {
                    myArray[q, w] = random.Next(333, 888);

                    System.Console.Write(myArray[q, w] + "\t");
                }
                System.Console.WriteLine();

            }


        }
    }
}
