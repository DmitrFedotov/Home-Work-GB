using System;

namespace Home_Work_4
{
    class Program
    {
        static void Main(string[] args)
        {
            GetFullName("Пупкин", "Василий", "Игнатьевич");
            GetFullName("Романов", "Владимир", "Владимирович");
            GetFullName("Дружко", "Сергей", "Евгеньевич");
        }

        static void GetFullName(string lastName, string firstName, string patronymic)
        {
            Console.WriteLine($"{lastName} {firstName} {patronymic}");
            return;

        }



    }
}
