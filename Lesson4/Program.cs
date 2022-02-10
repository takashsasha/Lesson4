using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    class Program
    {
        enum season
        {
            Winter,
            Spring,
            Summer,
            Autumn
        }
        static void Main(string[] args)
        {
            season SeasonIndentification(int numM)
            {
                switch (numM)
                {
                    case 3:
                    case 4:
                    case 5:
                        return season.Spring;
                    case 6:
                    case 7:
                    case 8:
                        return season.Summer;
                    case 9:
                    case 10:
                    case 11:
                        return season.Autumn;
                    default:
                        return season.Winter;
                }
            }

            string NameMonth(season seasons)
            {
                switch (seasons)
                {
                    case season.Spring:

                        return "Весна";

                    case season.Summer:

                        return "Лето";

                    case season.Autumn:

                        return "Осень";

                    default:
                        return "Зима";
                }
            }
            Console.WriteLine("Введите номер текущего месяца");
            int numMonth = Int32.Parse(Console.ReadLine());
            if (numMonth > 0 && numMonth < 13)
            {
                season seasons = SeasonIndentification(numMonth);
                string seasonOfYear = NameMonth(seasons);
                Console.WriteLine(seasonOfYear);
            }
            else
            {
                Console.WriteLine("Ошибка: введите число от 1 до 12");
            }
            Console.ReadKey();
            //
            
        }

    }
}
