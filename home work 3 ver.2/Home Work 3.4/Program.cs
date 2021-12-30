using System;
using System.IO;
using System.Text;

namespace Home_Work_3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            char[ , ] varbox = new char[10,10];
            varbox[0, 0] = 'X';

            varbox[0, 9] = 'X';

            varbox[9, 9] = 'X';

            varbox[9, 0] = 'X';



            varbox[0, 5] = 'X';
            varbox[0, 6] = 'X';

            varbox[3, 1] = 'X';
            varbox[4, 1] = 'X';

            varbox[7, 3] = 'X';
            varbox[7, 4] = 'X';



            varbox[2, 4] = 'X';
            varbox[3, 4] = 'X';
            varbox[4, 4] = 'X';

            varbox[5, 7] = 'X';
            varbox[5, 8] = 'X';
            varbox[5, 9] = 'X';



            varbox[3, 6] = 'X';
            varbox[3, 7] = 'X';
            varbox[3, 8] = 'X';
            varbox[3, 9] = 'X';
            
            


            for (int i = 0; i < varbox.GetLength(0); i++)
            {
                for (int j = 0; j < varbox.GetLength(1); j++)
                {
                    char correction = varbox[i, j];

                    if (correction != 'X')
                    {
                        varbox[i, j] = 'O';
                    }

                    System.Console.Write($"{varbox[i, j]} " );

                }
                System.Console.WriteLine();
            }


        }
    }
}
