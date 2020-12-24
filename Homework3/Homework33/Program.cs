using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
3.Написать программу, выводящую введённую пользователем строку в обратном порядке (olleH вместо Hello).
*/
namespace Homework33
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку: ");
            string Value = Console.ReadLine();

            for (int i = Value.Length - 1; i >= 0; i--)
                Console.Write(Value[i]);
            Console.WriteLine();
        }
    }
}
