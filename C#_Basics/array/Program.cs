using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a row of matrix: ");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a row of matrix: ");
            int col = Convert.ToInt32(Console.ReadLine());
            int[,] values = new int[row, col];
            for(int i = 0; i < row; i++)
            {
                for(int j = 0; j < col; j++)
                {
                    values[i,j] = Convert.ToInt32(Console.ReadLine());
                }

            }

            Console.WriteLine("The values are");
            for (int i = 0; i < row; i++) 
            { 
                for(int j = 0; j < col; j++)
                {
                    Console.Write(values[i,j] + " ");
                }
                Console.WriteLine();
            }


            Console.WriteLine("TRANSPOSE");
            for(int i = 0;i < col; i++)
            {
                for(int j = 0;j < row; j++)
                {
                    Console.Write(values[j, i] + " ");
                }
                Console.WriteLine();
            }

            
            
            
        }
    }
}


           



