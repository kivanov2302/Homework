using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algor_home_2_2
{
    class Program
    {
        static int[] a = new int[20];
        static int counter;
        static void Main(string[] args)
        {
            arrGen();
            rez(a); 
            Console.ReadKey();
        }
        static void rez(int[] a)
        {
            Console.Write("Ввести элемент поиска: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int k = binPoisk(b);    // O(log n)
            Console.WriteLine("Бинарный поиск:");
            if (k > -1)
                Console.WriteLine("Номер элемента = {0}, число сравнений внутри цикла = {1}", k, counter);
            else
                Console.WriteLine("нет заданного элемента, число сравнений внутри цикла = {0}", counter);
        }
        static void arrGen()
        {
            Random ran = new Random();
            a[0] = ran.Next(1, 6);
            Console.Write("  {0}", a[0]);
            for (int i = 1; i < a.Length; i++)
            {
                a[i] = a[i - 1] + ran.Next(1, 6);
                Console.Write("  {0}", a[i]);
            }
            Console.WriteLine();
        }
        static int binPoisk(int b)
        {
            int k;
            int L = 0;
            int R = a.Length - 1;
            k = (R + L) / 2;
            while (L < R - 1)
            {
                counter++;
                k = (R + L) / 2;
                if (a[k] == b)
                    return k;
                counter++;
                if (a[k] < b)
                    L = k;
                else
                    R = k;
            }
            if (a[k] != b)
            {
                if (a[L] == b)
                    k = L;
                else
                {
                    if (a[R] == b)
                        k = R;
                    else
                        k = -1;
                };
            }
            return k;
        }
    }
}