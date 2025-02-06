using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identity_matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int row, col;
            int count = 0;
            Console.WriteLine("enter a row of matrix");
            row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a col of matrix");
            col = Convert.ToInt32(Console.ReadLine());
            int[,] ints = new int[row, col];

            for (int i = 0; i < row; i++)
            {

                string[] input = Console.ReadLine().Split(' ');

                for (int j = 0; j < col; j++)
                {

                    ints[i, j] = Convert.ToInt32(input[j]);
                }
            }
            Console.WriteLine("the values are");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(ints[i, j] + " ");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if ((i == j && ints[i, j] == 1) || (i != j && ints[i, j] == 0))
                    {
                        count++;
                    }
                }
            }
            if (count == row * col)
            {
                Console.WriteLine("Its identity matrix");
            }
            else
            {
                Console.WriteLine("It's not a identity matrix");
            }

        }
    }
}
