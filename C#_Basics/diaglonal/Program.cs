using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diaglonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the row of matrix");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the column of matrix");
            int col = Convert.ToInt32(Console.ReadLine());
            int[,] valu = new int[row, col];
            if(row == col)
            {
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        Console.WriteLine($"the enter the elements {i}{j}");
                        valu[i, j] = Convert.ToInt32(Console.ReadLine());

                    }
                }
                
                Console.WriteLine("The values are");
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        Console.Write(valu[i, j] + " ");
                    }
                    Console.WriteLine();
                }

                int diagonalSum = 0;
                int mini = 0;

                Console.Write("Main diagonal elements: ");
                for (int i = 0; i < row; i++)
                {
                    diagonalSum += valu[i, i];
                    Console.Write(valu[i, i] + " ");
                }

                Console.WriteLine();

                // Print anti-diagonal and calculate its sum
                Console.Write("Anti-diagonal elements: ");
                for (int i = 0; i < row; i++)
                {
                    mini += valu[i, row - i - 1];
                    Console.Write(valu[i, row - i - 1] + " ");
                }

                Console.WriteLine();
                Console.WriteLine("The difference of both diagonals is: ");
                int dif = diagonalSum - mini;
                Console.WriteLine(dif);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("ROW and COLUMN should be equal");
            }
            
        }
    }
}
          

               
          
