using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            // объявление переменных
            string name;
            DateTime date;
            // Сообщение
            Console.WriteLine("Введите имя:");
            // присвоение значений переменным
            name = Console.ReadLine();
            date = DateTime.Now;
            //Вывод результата
            Console.WriteLine($"Привет, {name}, сегодня {date}");
            Console.ReadKey();
        }
    }
}
