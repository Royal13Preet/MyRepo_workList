using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxandMin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 0,1, 5, 7, 3,89, 5, 9, 8 };
            int large = arr[0];
            int small = arr[0];
            for (int i = 1; i < arr.Length; i++)
            { 
                if(arr[i] > large)
                {
                    large = arr[i];
                }
                
                
            }
            for (int i = 1; i < small; i++)
            {
                if (arr[i] < small)
                { 
                    small = arr[i];
                }
            }
            Console.WriteLine(small);
            Console.WriteLine(large);
        }
    }
}
