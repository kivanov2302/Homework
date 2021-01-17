using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algor_home_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = 5;
            Console.WriteLine(f(n));
            n = 4;
            Console.WriteLine(f(n));
        }
        static bool f(int number)
        {
            int d = 0;
            int i = 2;
            while (i < number)
            {
                if (number % i == 0)
                    d++;
                i++;
            }

            return d == 0;
        }
    }
}
