using System;
using System.IO;

namespace homeWork5._4
{
    class Program
    {
        static void Main(string[] args)
        {
            string info = @"C:\AMD";

            string[] entries = Directory.GetFileSystemEntries(info, "*", SearchOption.AllDirectories);

            string[] rec = Directory.

            for (int i = 0; i < entries.Length; i++)
            {
                Console.WriteLine(entries[i]);                
            }
            File.AppendAllLines("Directoriya.txt" , entries);
            

        }
    }
}
