using System;
using System.Linq;
using System.IO;
using System.Diagnostics;


namespace Home_Work_6
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isRun = true;
            while (isRun)
            {
                Process[] procList = Process.GetProcesses();
                foreach (Process proc in procList)
                {
                    Console.WriteLine($"{proc.Id} {proc.ProcessName} {proc.BasePriority}");
                }
                Console.Write("name = ");
                string name = Console.ReadLine();
                try
                {
                    procList.First(p => p.ProcessName.ToLower() == name.ToLower()).Kill();
                    Console.WriteLine($"{name} deleted!");
                }
                catch (InvalidOperationException)
                {
                    Console.WriteLine($"Process {name} not found!");
                }
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
