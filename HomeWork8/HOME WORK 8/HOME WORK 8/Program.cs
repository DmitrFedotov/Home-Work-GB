using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HOME_WORK_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string save = "text.txt";
            string fileText = File.ReadAllText(save);
            Console.WriteLine(fileText);


            string greeting = Properties.Settings.Default.Greeting;


            if (string.IsNullOrEmpty(Properties.Settings.Default.UserName))
            {

                Console.WriteLine("Введите имя пользователя:");
                Properties.Settings.Default.UserName = Console.ReadLine();
                Properties.Settings.Default.Save();
            }
            string userName = Properties.Settings.Default.UserName;

            Console.WriteLine($"{greeting}, {userName}!");



            if (string.IsNullOrEmpty(Properties.Settings.Default.UserArge))
            {

                Console.WriteLine("Введите возраст:");
                Properties.Settings.Default.UserArge = Console.ReadLine();
                Properties.Settings.Default.Save();
            }
            string UserArge = Properties.Settings.Default.UserArge;

            Console.WriteLine($"{UserArge}!");

            if (string.IsNullOrEmpty(Properties.Settings.Default.UserPofession))
            {

                Console.WriteLine("Введите род деаятельности:");
                Properties.Settings.Default.UserPofession = Console.ReadLine();
                Properties.Settings.Default.Save();
            }
            string UserPofession = Properties.Settings.Default.UserPofession;

            Console.WriteLine($"{UserPofession}!");
        }
    
    }
}