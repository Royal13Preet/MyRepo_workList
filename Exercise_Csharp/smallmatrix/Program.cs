using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smallmatrix
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("enter the row of matrix");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the col of matrix");
            int col = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[row,col];
            for(int i = 0; i<row; i++)
            {

                string[] input = Console.ReadLine().Split(' ');
                
                for (int j = 0; j<col; j++)
                {
                    
                    array[i, j] = Convert.ToInt32(input[j]);
                    i--;
                }
            }
            int small = array[0, 0];

            for (int i = 0; i < row; i++) 
            {

                for(int j = 0;j<col; j++)
                {
                    if(array[i, j] < small)
                    {
                        small = array[i, j];
                    }
                }
            }
            Console.WriteLine(small);
        }
    }
}
