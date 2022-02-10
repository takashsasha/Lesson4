using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            string GetFullName(string firstName, string lastName, string patronymic)
            {
                string FIO = firstName + " " + lastName + " " + patronymic;
                return FIO;
            }
            Console.WriteLine(GetFullName("Имя1", "Фамилия1", "Отчество1"));
            Console.WriteLine(GetFullName("Имя2", "Фамилия2", "Отчество2"));
            Console.WriteLine(GetFullName("Имя3", "Фамилия3", "Отчество3"));
            Console.WriteLine(GetFullName("Имя4", "Фамилия4", "Отчество4"));
            Console.ReadKey();
        }
    }
}
