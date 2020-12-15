using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
4.(*) Если пользователь указал месяц из зимнего периода, а средняя температура > 0, вывести сообщение «Дождливая зима».
*/

namespace Homework24
{
    class Program
    {
        enum Month
        {
            Январь  = 1,
            Февраль = 2,
            Март    = 3,
            Апрель  = 4,
            Май     = 5,
            Июнь    = 6,
            Июль    = 7,
            Август  = 8,
            Сентябрь = 9,
            Октябрь = 10,
            Ноябрь  = 11,
            Декабрь = 12

        }
        static void Main(string[] args)
        {
            Console.Write("Минимальная темперетура за сутки: ");
            float minT = Int32.Parse(Console.ReadLine());
            Console.Write("Максимальная темперетура за сутки: ");
            float maxT = Int32.Parse(Console.ReadLine());
            float ave = (minT + maxT) / 2;

            Console.Write("Введите месяц (1-12): ");
            int idMonth = Int32.Parse(Console.ReadLine());
            Console.WriteLine((Month)idMonth);
            Console.WriteLine($"Cреднесуточная температура: {ave}");

            if ((idMonth == 12 || idMonth == 1 || idMonth == 2) && ave > 0) {
                Console.WriteLine("Дождливая зима");
            }
        }
    }
}
