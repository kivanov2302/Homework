using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
2. Написать программу «Телефонный справочник»: создать двумерный массив 5х2, хранящий список телефонных контактов: первый элемент хранит имя контакта, второй — номер телефона/email.
*/
namespace Homework32
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5, b = 2;
            string[,] mass = new string[a, b];

            int ink = 0;
            bool flag = false;
            do
            {
                Console.WriteLine("Введите имя: ");
                string name = Console.ReadLine();
                for (int i = 0; i < name.Length; i++)
                {
                    if (!(Char.IsLetter(name[i]) || name[i] == ' '))
                    {
                        Console.WriteLine("В имене не должно быть цифр");
                        flag = !flag;
                        break;
                    }
                }
                if (flag)
                {
                    flag = !flag;
                    continue;
                }    
                Console.WriteLine(@"Введите номер телефона/email: ");
                string info = Console.ReadLine();
                mass[ink, 0] = name;
                mass[ink, 1] = info;
                ink++;
            } while (mass.GetLength(0) > ink);

            Console.Clear();

            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    Console.Write($" {mass[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
