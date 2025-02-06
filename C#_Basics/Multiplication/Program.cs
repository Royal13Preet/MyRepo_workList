using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a First Matrix");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a Column");
            int col = Convert.ToInt32(Console.ReadLine());
            int[,] values = new int[row, col];
            for (int i = 0; i < row; i++)
            {
                for(int j = 0; j < col; j++)
                {
                    values[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Enter the row of matrix 2");
            int row1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the column of matrix 2");
            int col1 = Convert.ToInt32(Console.ReadLine());
            int[,] values1 = new int[row1, col1];
            for(int i = 0;i < row1; i++)
            {
                for (int j = 0;j < col1; j++)
                {
                    values1[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            if (col != row1)
            {
                Console.WriteLine("Matrix multiplication is not possible. Number of columns in Matrix 1 must equal the number of rows in Matrix 2.");
                return;
            }

           
            int[,] result = new int[row, col1];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col1; j++)
                {
                    result[i, j] = 0;
                    for (int k = 0; k < col; k++)
                    {
                        result[i, j] += values[i, k] * values1[k, j];
                    }
                }
            }
            
            Console.WriteLine("Resultant Matrix after multiplication:");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col1; j++)
                {
                    Console.Write(result[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
   
        
    
}
