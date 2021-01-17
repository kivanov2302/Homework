using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algor_home_1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = 0;
            Console.WriteLine(f_rec(n) + "/"+ f_loop(n));
            n = 1;
            Console.WriteLine(f_rec(n) + "/" + f_loop(n));
            n = 2;
            Console.WriteLine(f_rec(n) + "/" + f_loop(n));
            n = 3;
            Console.WriteLine(f_rec(n) + "/" + f_loop(n));
            n = 4;
            Console.WriteLine(f_rec(n) + "/" + f_loop(n));
            n = 10;
            Console.WriteLine(f_rec(n) + "/" + f_loop(n));
            n = 20;
            Console.WriteLine(f_rec(n) + "/" + f_loop(n));
        }

        static int f_rec(int n) // O(2N^2)
        {
            int result = 0;
            if (n == 0)
                result = 0;
            else if (n == 1)
                result = 1;
            else
                result = f_rec(n - 2) + f_rec(n - 1);
            return result;
        }

        static int f_loop(int n) // O(3N)
        {
            int f_0 = 0;
            int f_1 = 1;
            int result = 0;
            if (n == 1)
                result = f_1;

            for (int i = 0; i < n - 1; i++)
            {
                result = f_0 + f_1;
                f_0 = f_1;
                f_1 = result;
            }

            return result;
        }
    }
}
