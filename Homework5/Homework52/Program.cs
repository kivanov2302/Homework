using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
2. Написать программу, которая при старте дописывает текущее время в файл «startup.txt».
*/
namespace Homework52
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = "startup.txt";
            File.AppendAllLines(filename, new[] { Convert.ToString(DateTime.Now), Environment.NewLine });
            Console.WriteLine("Файл записан");
        }
    }
}
