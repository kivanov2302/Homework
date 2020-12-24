using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
1. Написать программу, выводящую элементы двумерного массива по диагонали.
*/
namespace Homework31
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            int a = 5, b = 5;
            int[,] mass = new int[a, b];

            Console.WriteLine("Исходная матрица:");
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    mass[i, j] = random.Next(10, 99);
                    Console.Write($" {mass[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Диагональ \\");
            for (int i = 0; i < mass.GetLength(0); i++)
                Console.Write($" {mass[i, i]} ");
            Console.WriteLine();
            for (int i = mass.GetLength(0) - 1; i >= 0; i--)
                Console.Write($" {mass[i, i]} ");
            Console.WriteLine();

            Console.WriteLine("Диагональ /");
            int len = mass.GetLength(0) - 1;
            for (int i = 0; i <= len; i++)
                Console.Write($" {mass[len - i, i]} ");
            Console.WriteLine();
            for (int i = 0; i <= len; i++)
                Console.Write($" {mass[i, len - i]} ");
            Console.WriteLine();
        }
    }
}
/*
00 01 02 03 04
10 11 12 13 14
20 21 22 23 24
30 31 32 33 34
40 41 42 43 44
*/