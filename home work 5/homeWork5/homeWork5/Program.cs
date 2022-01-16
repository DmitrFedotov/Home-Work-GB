using System;
using System.IO;

namespace домашнее_Задание_4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            File.WriteAllText("my_file.txt", "Hello my teacher☺");

            if (File.Exists("my_file.txt"))
            {
                System.Console.WriteLine("файл готов");
            }

            string readText = File.ReadAllText("my_file.txt");

            System.Console.WriteLine(readText);
        }
    }
}
