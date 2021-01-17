using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algor_home_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 12, 2, 32, 15 };
            StrangeSum(arr);
        }
        public static int StrangeSum(int[] inputArray)
        {
            int sum = 0;
            for (int i = 0; i < inputArray.Length; i++)             //O(N)
            {
                for (int j = 0; j < inputArray.Length; j++)         //O(N)
                {
                    for (int k = 0; k < inputArray.Length; k++)     //O(N)
                    {
                        int y = 0;                                  //O(1N)

                        if (j != 0)                                 //O(1N)
                        {
                            y = k / j;                              //O(1N)
                        }

                        sum += inputArray[i] + i + k + j + y;       //O(1N)
                    }
                }
            }
                                                                    //O(4N^3)
            return sum;
        }
    }
 }
