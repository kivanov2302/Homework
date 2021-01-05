using System;
using System.Collections.Generic;
using System.Buffers;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System.Text.Json;
/*
5. (*) Список задач(Task-list):
    написать приложение для ввода списка задач;
    задачу описать классом Task с полями Title и IsDone;
    на старте, если есть файл tasks.json/xml/bin (выбрать формат), загрузить из него массив имеющихся задач и вывести их на экран;
    если задача выполнена, вывести перед её названием строку «[x]»;
    вывести порядковый номер для каждой задачи;
    при вводе пользователем порядкового номера задачи отметить задачу с этим порядковым номером как выполненную;
    записать актуальный массив задач в файл tasks.json/xml/bin.
*/
namespace Homework55
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"tasks.json";
            if (File.Exists(path))
            {
                Console.WriteLine("Существует");
                
                string json = File.ReadAllText(path);
                List<Task> Tasks = JsonSerializer.Deserialize<List<Task>>(json);
                filling(Tasks, path);
            }
            else
            {
                List<Task> Tasks = new List<Task>();
                filling(Tasks, path);
            }
        }
        static void menu()
        {
            Console.Clear();
            Console.WriteLine(@"<Выберете действие>");
            Console.WriteLine("1. Добавить задачу");
            Console.WriteLine("2. Записать");
            Console.WriteLine("3. Просмотр");
            Console.WriteLine("4. Изменить");
            Console.WriteLine("5. Выход");
        }
        static void filling(List<Task> array, string path)
        {
            Console.Clear();
            menu();
            ConsoleKeyInfo action = Console.ReadKey();
            Console.WriteLine();
            switch (action.KeyChar)
            {
                case '1':
                    //Добавить задачу в массив
                    AddTask(array, path);
                    break;
                case '2':
                    //Записать содержимое массива
                    WriteData(array, path);
                    break;
                case '3':
                    //Просмотр массива
                    ViewTasks(array, path);
                    break;
                case '4':
                    //Закрыть приложение
                    UpdateTask(array, path);
                    break;
                case '5':
                    //Закрыть приложение
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Введите число от 1 до 5");
                    Thread.Sleep(1000);
                    filling(array, path);
                    break;
            }
        }
        static void AddTask(List<Task> array, string path)
        {
            Console.Clear();
            Console.WriteLine(@"Наименование задачи:");
            string Title = Console.ReadLine();
            Console.WriteLine(@"Статус выболнения(0/1):");
            ConsoleKeyInfo _IsDone;
            do
            {
                _IsDone = Console.ReadKey();
            }
            while (!(_IsDone.KeyChar == '0' || _IsDone.KeyChar == '1'));
            bool IsDone = (_IsDone.KeyChar == '0' ? false : true);
            Task task = new Task(Title, IsDone);
            array.Add(task);
            filling(array, path);
        }
        static void ViewTasks(List<Task> array, string path, bool View = true)
        {
            Console.Clear();
            int iter = 1;
            foreach (Task s in array)
            {
                Console.WriteLine("{0} {1} {2}", iter, (s.IsDone == true ? "[х]" : "[о]"), s.Title);
                iter++;
            }
            Console.ReadKey();
            filling(array, path);
        }
        static void WriteData(List<Task> array, string path)
        {
            Console.Clear();
            File.WriteAllText(path, "");
            string json = JsonSerializer.Serialize(array);
            File.AppendAllText(path, json);
            Console.WriteLine("Файл записан");
            Thread.Sleep(1000);
            filling(array, path);
        }
        static void UpdateTask(List<Task> array, string path)
        {
            Console.Clear();
            Console.WriteLine("Для изменеия статуса задачи нажмите её номер \nДля выхода в Меню нажмите <Backspace>");
            int iter = 1;
            foreach (Task s in array)
            {
                Console.WriteLine("{0} {1} {2}", iter, (s.IsDone == true ? "[х]" : "[о]"), s.Title);
                iter++;
            }
            ConsoleKeyInfo action = Console.ReadKey();
            if (action.Key == ConsoleKey.Backspace)
            {
                filling(array, path);
            }
            else
            {
                string pos = action.KeyChar.ToString() + Console.ReadLine();
                int posInt = 0;
                try
                {
                    posInt = Int32.Parse(pos);
                    array[posInt - 1].IsDone = !array[posInt - 1].IsDone;
                }
                catch
                {
                    Console.WriteLine("Введеное значение за пределами массива или не число.");
                    Thread.Sleep(1000);
                }
                UpdateTask(array, path);
            }
            
        }

    }
}
