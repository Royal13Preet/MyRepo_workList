using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buublesort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 13, 4, 542, 234, 12, 54, 2, 45, 6, 9 };
            int temp = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine($"3rd largest element: {arr[arr.Length - 3]}");

            //foreach (int i in arr)
            //{
            //    Console.WriteLine(i);
            //}
        }
    }
}
