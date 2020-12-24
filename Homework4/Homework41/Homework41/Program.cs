using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
1. Написать метод GetFullName(string firstName, string lastName, string patronymic), принимающий на вход ФИО в разных аргументах и возвращающий объединённую строку с ФИО. Используя метод, написать программу, выводящую в консоль 3–4 разных ФИО.
*/
namespace Homework41
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetFullName("Кирилл"      , "Емельянов"   , "Андреевич"));
            Console.WriteLine(GetFullName("Мария"       , "Соловьева"   , "Александровна"));
            Console.WriteLine(GetFullName("Алексей"     , "Руднев"      , "Владимирович"));
            Console.WriteLine(GetFullName("Станислав"   , "Вензик"      , "Владимирович"));
        }
        static string GetFullName(string firstName, string lastName, string patronymic)
        {
            return $"{lastName} {firstName} {patronymic}";
        }
    }
}
