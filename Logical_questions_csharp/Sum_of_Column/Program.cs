using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_Column
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a row");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a column");
            int col = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[row, col];
            for (int i = 0; i < row; i++)
            {
                string[] inpu = Console.ReadLine().Split(' ');
                if (inpu.Length != col)
                {
                    Console.WriteLine($"Your col elements are {col} , but recived {inpu.Length}. Please re enter row {i + 1}");
                    i--;
                    continue;
                }
                for (int j = 0; j < col; j++)
                {
                    array[i, j] = Convert.ToInt32(inpu[j]);
                }
            }




            Console.WriteLine("the values are");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("the sum of columns");
            for (int j = 0; j < col; j++)
            {
                int total = 0;
                for (int i = 0; i < row; i++)
                {
                    total += array[i, j];
                }
                Console.WriteLine($"col {j}: {total}");
            }
        }

    }
}

