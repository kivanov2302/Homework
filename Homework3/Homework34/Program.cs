using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
*«Морской бой»: вывести на экран массив 10х10, состоящий из символов X и O, где Х — элементы кораблей, а О — свободные клетки.
*/
namespace Homework34
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 10;
            string[,] box = new string[a, b];
            for(int i = 0; i < box.GetLength(0); i++)
            {
                for(int j = 0; j < box.GetLength(1); j++)
                {
                    box[i, j] = "O ";
                    Console.Write(box[i, j]);
                }
                Console.WriteLine();
            }
 
            //4 - 1
            pull(4, 1, 1,  0, box);
            //3 - 2
            pull(3, 1, 3,  1, box);
            pull(3, 5, 6,  0, box);
            //2 - 3
            pull(2, 1, 8,  0, box);
            pull(2, 3, 5,  1, box);
            pull(2, 9, 5,  1, box);
            //1 - 4
            pull(1, 9, 9,  0, box);
            pull(1, 7, 2,  0, box);
            pull(1, 5, 10, 0, box);
            pull(1, 5, 4,  0, box);

            Console.Clear();
            for (int i = 0; i < box.GetLength(0); i++)
            {
                for (int j = 0; j < box.GetLength(1); j++)
                {
                    Console.Write(box[i, j]);
                }
                Console.WriteLine();
            }

          }
        static void pull(int figure, int CoordX, int CoordY, int line, string[,] box)
        {
            if (line == 1)
            {
                for (int i = 0; i < figure; i++)
                {
                    box[CoordX - 1, CoordY - 1 + i] = "X ";
                }
            }
            else if (line == 0)
            {
                for (int i = 0; i < figure; i++)
                {
                    box[CoordX - 1 + i, CoordY - 1] = "X ";
                }
            }
      }
    }
}
