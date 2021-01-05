using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
4. (*) Сохранить дерево каталогов и файлов по заданному пути в текстовый файл — с рекурсией и без.
*/
namespace Homework54
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathSave = "logGetFileSystemEntries.txt";
            string pathRead = @"E:\Homework\Homework\Homework5";
            string[] entries = Directory.GetFileSystemEntries(pathRead, "*", SearchOption.AllDirectories);
            File.WriteAllText(pathSave, "");
            foreach (string s in entries)
            {
                File.AppendAllLines(pathSave, new[] { s, Environment.NewLine });
            }
           
            pathSave = "logRec.txt";
            File.WriteAllText(pathSave, "");
            var re = new List<string>();
            dirHierarchy(re, pathRead);
            foreach (string s in re)
            {
                File.AppendAllLines(pathSave, new[] { s, Environment.NewLine });
            }

        }
        static void dirHierarchy(List<string> arr, string dir)
        {
            string[] dirs = Directory.GetDirectories(dir);
            foreach (string s in dirs)
            {
                arr.Add(s);
                dirHierarchy(arr, s);
            }
            string[] files = Directory.GetFiles(dir);
            foreach (string s in files)
            {
                arr.Add(s);
            }
        }
    }
}
