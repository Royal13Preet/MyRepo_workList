using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrixmul
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a row of matrix");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a column of the matrix");
            int col = Convert.ToInt32(Console.ReadLine());
            int[,] values = new int[row, col];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    values[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Enter a row of matri2");
            int row1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the column of matrix2");
            int col1 = Convert.ToInt32(Console.ReadLine());
            int[,] values1 = new int[row1, col1];
            for (int i = 0; i < row1; i++)
            {
                for (int j = 0; j < col1; j++)
                {
                    values1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("The values of first matrix are: ");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(values[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("The values of second matrix are: ");
            for (int i = 0; i < row1; i++)
            {
                for (int j = 0; j < col1; j++)
                {
                    Console.Write(values1[i, j] + " ");
                }
                Console.WriteLine();
            }
            if (col != row1)
            {
                Console.WriteLine("Multiplication is not possible");
            }
            else
            {
                int[,] multi = new int[row, col1];
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col1; j++)
                    {
                        multi[i, j] = 0;
                        for (int k = 0; k < col; k++)
                        {
                            multi[i, j] += values[i, k] * values1[k, j];
                        }
                    }
                }
                Console.WriteLine("The multiplication of the two matrix: ");
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col1; j++)
                    {
                        Console.Write(multi[i, j] + " ");
                    }
                    Console.WriteLine();
                }

            }
                


        }


    }
}
    
