using System;

namespace домашнее_задание_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Введите данные пользователя, сначало вводите Ф.И.О далее номер тиелефона либо e-mail ");
            string[,] book = new string[,]
            {

              { System.Console.ReadLine(), System.Console.ReadLine()},
              { System.Console.ReadLine(), System.Console.ReadLine()},
              { System.Console.ReadLine(), System.Console.ReadLine()},
              { System.Console.ReadLine(), System.Console.ReadLine()},
              { System.Console.ReadLine(), System.Console.ReadLine()}

            };
            System.Console.WriteLine("Ваш справочник");

            book[0, 0] = "---Ф.И.О контакта---";

            book[0, 1] = "--------Номер или e-mail--------";

            for (int i = 0; i < book.GetLength(0); i++)
            {

                for (int q = 0; q < book.GetLength(1); q++)
                {

                    System.Console.Write(book[i, q] + "\t");

                }
                System.Console.WriteLine();
            }
            System.Console.ReadLine();

        }
    }
}