using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
 
         
            int[][] arr = new int[4][];

            
            arr[0] = new int[5];
            arr[1] = new int[6];
            arr[2] = new int[4];
            arr[3] = new int[5];

          
            Console.WriteLine("Printing the Default Values of Jagged Array:");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
              
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j] + " ");
                }
                Console.WriteLine();
            }

        
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                int num = 10;
                for (int j = 0; j < arr[i].Length; j++)
                {
                    num++;
                    arr[i][j] = num;
                }
               
            }

           
            Console.WriteLine("\n\nPrinting the Values of Jagged Array:");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                foreach (int x in arr[i])
                {
                    Console.Write(x + " ");
                }
                Console.WriteLine();
            }


            //You cannot simply use a foreach loop to Print the Values of a foreach loop
            //foreach (var item in arr)
            //{
            //    Console.Write(item);
            //}
            Console.ReadKey();
            
        }
    }
}
