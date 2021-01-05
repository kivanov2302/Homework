using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
/*
3. Ввести с клавиатуры произвольный набор чисел (0...255) и записать их в бинарный файл.
*/
namespace Homework53
{
    class Program
    {
        static void Main(string[] args)
        {
            int ValueInt;
            string ValueStr;
            bool flag = true;
            var Value = new List<byte>();
            Console.WriteLine("Введите набор чисел (0...255) или W для записи: ");
            do
            {
                Console.WriteLine("Введите набор чисел (0...255): ");
                ValueStr = Console.ReadLine();
                if (ValueStr == "W" || ValueStr == "w")
                {
                    flag = !flag;
                }
                else if (IsNumber(ValueStr))
                {
                    ValueInt = Int32.Parse(ValueStr);
                    if (ValueInt >= 0 && ValueInt <= 255)
                        Value.Add(byte.Parse(ValueStr));
                    else
                        Console.WriteLine("Значение {0} не корректно, будте внимательне.", ValueStr);
                }
                else
                {
                    Console.WriteLine("Значение {0} не корректно, будте внимательне.", ValueStr);
                }
            }
            while (flag);
            string filename = "binfile.bin";
            File.WriteAllBytes(filename, Value.ToArray());
            Console.WriteLine("Файл записан.");
        }

        static bool IsNumber(string str)
        {
            bool flag = true;
            for (int i = 0; i < str.Length; i++)
            {
                flag = Char.IsNumber(str[i]);
                if (!flag)
                    break;
            }
            return flag;
        }
    }
}
