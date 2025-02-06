using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jaggedarray
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[][] arr1 = new int[2][];
            arr1[0] = new int[] { 23, 45, 65, 43, 34 };
            arr1[1] = new int[] { 45, 67 };
            for (int i = 0; i < arr1.Length; i++) { 
                for(int j = 0; j < arr1[i].Length; j++)
                {
                    Console.Write(arr1[i][j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
