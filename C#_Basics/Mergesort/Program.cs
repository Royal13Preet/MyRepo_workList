using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Selectionsort

{
    internal class Program
    {
        
        static void Main(string[] args)
        {
           
            int[] arr = new int[] { 67, 4, 98, 6, 56, 35, 987, 24, 2 };
            
           
            int i;
            for ( i = 0; i < arr.Length-1; i++) {
                int small = i;
                for( int j = i+1; j < arr.Length; j++)
                {
                    if(arr[j] > arr[small])
                    {
                        small = j;
                    }
                }
                int temp = arr[i];
                arr[i] = arr[small];
                arr[small] = temp;
            }
//i = 0, j = 1 
            foreach (int x in arr) { 
                Console.WriteLine(x);
            }
            
        }
    }
}
