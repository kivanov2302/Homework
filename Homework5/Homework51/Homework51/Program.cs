using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
1. Ввести с клавиатуры произвольный набор данных и сохранить его в текстовый файл.
*/
namespace Homework51
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = "textfile.txt";
            Console.WriteLine("Введите строку: ");
            string str = Console.ReadLine();
            File.WriteAllText(filename, str);
            Console.WriteLine("Файл записан");
        }
    }
}
