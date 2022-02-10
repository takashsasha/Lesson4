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
            int sum = 0;
            Console.WriteLine("Введите строку чисел");
            string stringNum = Convert.ToString(Console.ReadLine());
            int sumNum(string sN)
            {

                string[] subs = stringNum.Split(' ');
                foreach (var word in subs)
                {
                    sum = sum + Convert.ToInt32(word);
                }
                return sum;
            }
            Console.WriteLine($"Суммма всех чисел в строке = {sumNum(stringNum)}");
            int num;
            Console.ReadKey();

        }
    }
}
