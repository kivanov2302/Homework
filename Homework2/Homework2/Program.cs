using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
1.Запросить у пользователя минимальную и максимальную температуру за сутки и вывести среднесуточную температуру.
*/

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Минимальная темперетура за сутки: ");
            float minT = Int32.Parse(Console.ReadLine());
            Console.Write("Максимальная темперетура за сутки: ");
            float maxT = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"Cреднесуточная температура: {(minT + maxT) / 2}");
        }
    }
}
