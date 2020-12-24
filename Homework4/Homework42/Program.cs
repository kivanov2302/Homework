using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
2. Написать программу, принимающую на вход строку — набор чисел, разделенных пробелом, и возвращающую число — сумму всех чисел в строке. Ввести данные с клавиатуры и вывести результат на экран.
 */
namespace Homework42
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = Console.ReadLine();
            bool ver = verification(value);
            if (ver)
                Console.WriteLine(numSum(value.Split(' ')));
            else
                Console.WriteLine("Ошибка ввода");
        }
        static int numSum(string[] values)
        {
            int rez = 0;
            foreach (var value in values)
            {
                rez = rez + (value == "" ? 0 : Convert.ToInt32(value));
            }

            return rez;
        }
        static bool verification(string value)
        {
            bool flag = true;
            for (int i = 0; i < value.Length; i++)
            {
                if (!(Char.IsNumber(value[i]) || value[i] == ' '))
                {
                    flag = !flag;
                    break;
                }
            }
            return flag;
        }
    }
}
