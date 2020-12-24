using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
4. (*) Написать программу, вычисляющую число Фибоначчи для заданного значения рекурсивным способом. 
*/
namespace Homework44
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите N элемент последовательности");
            int value = Int32.Parse(Console.ReadLine());
            Console.WriteLine(Fib(value));
        }
        static int Fib(int Value)
        {
            if (Value == 0)
            {
                return 0;
            }
            else if (Value == 1)
            {
                return 1;
            }
            else
            {
                return Fib(Value - 1) + Fib(Value - 2);
            }
        }
    }
}
