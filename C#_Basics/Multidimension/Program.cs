using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multidimension
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the row size");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the column size");
            int col = Convert.ToInt32(Console.ReadLine());
            int[,] arr2 = new int[row, col];
            int i, j = 0;
            for (i = 0; i < row; i++)
            {
                for (j = 0; j < col; j++)
                {
                    arr2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("the values are :");
            for (int k = 0; k < row; k++)
            {
                for (int l = 0; l < col; l++)
                {
                    Console.Write(arr2[k, l] + " ");
                    
                }

                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}

