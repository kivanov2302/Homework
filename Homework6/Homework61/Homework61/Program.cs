using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
/*
Написать консольное приложение Task Manager, которое выводит на экран запущенные процессы и позволяет завершить указанный процесс. 
Предусмотреть возможность завершения процессов с помощью указания его ID или имени процесса. 
В качестве примера можно использовать консольные утилиты Windows tasklist и taskkill.
*/
namespace Homework61
{
    class Program
    {
        static void Main(string[] args)
        {
            KillProcess();
        }
        static void Fill()
        {
            Process[] process = Process.GetProcesses();
            int fullProcess = 0;
            foreach (Process s in process)
            {
                string id = s.Id + "            ";
                Console.WriteLine("{0}  {1}", id.Substring(0, 10), s.ProcessName);
                fullProcess++;
            }
            Console.WriteLine("Всего процессов: {0}", fullProcess);
            Console.WriteLine("Для выхода нажмите <q>, для обновления списка процессов <r>");
        }
        static void KillProcess()
        {
            Console.Clear();
            Fill();
            string value = Console.ReadLine();
            if (value == "q" || value == "Q")
                return;
            if (value == "r" || value == "R")
            {
                KillProcess();
                return;
            }
            try
            {
                Process[] Processes = Process.GetProcessesByName(value);
                if (!(Processes.Length == 0))
                {
                    foreach (Process process in Processes)
                    {
                        Console.WriteLine(process.ProcessName);
                        process.Kill();
                    }
                }
                else
                {
                    int valueInt = Int32.Parse(value);
                    Process process = Process.GetProcessById(valueInt);
                    Console.WriteLine(process.ProcessName);
                    process.Kill();
                }
            }
            catch
            {
                Console.WriteLine("Не найден процесс, попробуйте дуругой");
            }
            Console.ReadKey();
            KillProcess();
        }
    }
}
