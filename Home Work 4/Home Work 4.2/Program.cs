using System;

namespace Home_Work_4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isRun = true;
            while (isRun)
            {
                Console.WriteLine("Введите последовательность чисел через пробел: ");

                string str = Console.ReadLine();

                string[] numberMass = str.Split(' ');
                int sum = 0;

                for (int i = 0; i < numberMass.Length; i++)
                {
                    sum = sum + Convert.ToInt32(numberMass[i]);
                }

                Console.WriteLine("{0}", sum);

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
