using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
3.Определить, является ли введённое пользователем число чётным.
*/

namespace Homework23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            Console.WriteLine(Int32.Parse(Console.ReadLine()) % 2 == 0 ? "Четное" : "Не четное");
        }
    }
}
