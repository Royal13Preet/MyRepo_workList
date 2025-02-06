using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrixaddition
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int row, col, i, j;
            Console.WriteLine("enter the row of matrices");
            row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the column matrices");
            col = Convert.ToInt32(Console.ReadLine());
            int[,] values = new int[row, col];
            int[,] values1 = new int[row, col];
            int[,] addmatrix = new int[row, col];
            Console.WriteLine($"Enter the first matrix");
            for (i = 0; i < row; i++)
            {
                for (j = 0; j < col; j++)
                {
                    Console.WriteLine($"Enter the elements {i}{j}");
                    values[i, j] = Convert.ToInt32(Console.ReadLine());
                }

            }

            Console.WriteLine("Enter the second matrix ");

            for (i = 0; i < row; i++)
            {
                for (j = 0; j < col; j++)
                {
                    Console.WriteLine($"enter a elements  {i}{j}");
                    values1[i, j] = Convert.ToInt32(Console.ReadLine());
                }


            }

            Console.WriteLine("the first matrix is");
            for (i = 0; i < row; i++)
            {
                for (j = 0; j < col; j++)
                {
                    Console.Write(values[i, j] + " ");

                }
                Console.WriteLine();
            }

            Console.WriteLine("the second matrix is");
            for (i = 0; i < row; i++)
            {
                for (j = 0; j < col; j++)
                {
                    Console.Write(values1[i, j] + " ");

                }
                Console.WriteLine();
            }


            for (i = 0; i < row; i++)
            {
                for (j = 0; j < col; j++)
                {
                    addmatrix[i, j] = values[i, j] + values1[i, j];
                }
            }

            Console.WriteLine("The sum of two matices are: ");
            for (i = 0; i < row; i++)
            {
                for (j = 0; j < col; j++)
                {
                    Console.Write(addmatrix[i, j] + " ");

                }
                Console.WriteLine();
            }


        }
        }
}


