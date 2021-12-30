using System;

namespace Home_Work_4._3
{
    class Program
    {
        enum seasons
        {
            winter,
            spring,
            summer,
            autumn

        }
        enum moth
        {
            January = 1,
            February = 2,
            March = 3,
            April = 4,
            May = 5,
            June = 6,
            July = 7,
            August = 8,
            September = 9,
            October = 10,
            November = 11,
            December = 12



        }
        static void Main(string[] args)
        //Запросить у пользователя порядковый номер текущего месяца и вывести его название.
        {
            bool isRun = true;
            while (isRun)
            {

                Console.WriteLine("Введите число, что-бы узнать месяц!");
                int a = int.Parse(Console.ReadLine());
                if (a > 0 && a < 13)
                {
                    Console.WriteLine($"Это месяц {(moth)a}");
                    a.ToString();
                    if ((a == 12) || (a <= 2)) Console.Write("Время года - зима          ");
                    else if ((a >= 3) && (a <= 5)) Console.Write("Время года - весна    ");
                    else if ((a >= 6) && (a <= 8)) Console.Write("Время года - лето     ");
                    else if ((a >= 9) && (a <= 11)) Console.Write("Время года - осень   ");

                }
                else
                {
                    Console.WriteLine("Ошибка: введите число от 1 до 12");
                    Console.WriteLine("Хотите продолжить? Y/N");
                    string userAnswer = Console.ReadLine();

                    if (userAnswer.ToUpper() == "N")
                    {
                        isRun = false;
                    }

                    Console.ReadKey();

                }


            }


        }
    }
}
