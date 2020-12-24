using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
/*
3. Написать метод по определению времени года. На вход подаётся число – порядковый номер месяца. 
На выходе — значение из перечисления (enum) — Winter, Spring, Summer, Autumn.Написать метод, 
принимающий на вход значение из этого перечисления и возвращающий название времени года (зима, весна, лето, осень). 
Используя эти методы, ввести с клавиатуры номер месяца и вывести название времени года. Если введено некорректное число, 
вывести в консоль текст «Ошибка: введите число от 1 до 12».
*/
namespace Homework43
{
    class Program
    {
        enum season  {
            Winter = 1,
            Spring,
            Summer,
            Autumn
        }
        enum seasonRu
        {
            Зима = 1,
            Весна,
            Лето,
            Осень
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите порядковый номер месяца(1-12): ");
            string Value = Console.ReadLine();
            if (Validation(Value))
                Console.WriteLine(getSeason(Int32.Parse(Value)));
            else
                Console.WriteLine("Ошибка: введите число от 1 до 12");
        }
        static bool Validation(string Value)
        {
            bool flag = true;
            for (int i = 0; i < Value.Length; i++)
            {
                if (!Char.IsNumber(Value[i]))
                    flag = !flag;
            }
            if (flag)
                flag = (1 <= Int32.Parse(Value) && Int32.Parse(Value) <= 12);

            return flag;
        }
        static seasonRu getSeason(int Value)
        {
            int Season = 0;
            if (Value == 12 || Value == 1 || Value == 2)
                Season = 1;
            if (Value >= 3 && Value <= 5)
                Season = 2;
            if (Value >= 6 && Value <= 8)
                Season = 3;
            if (Value >= 9 && Value <= 11)
                Season = 4;
            seasonRu Rez = (seasonRu)Season;
            return Rez;
        }
    }
}
