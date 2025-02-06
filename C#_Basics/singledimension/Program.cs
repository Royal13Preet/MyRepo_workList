using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singledimension
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Taking a values are integer
            //int r;
            //Console.WriteLine("enter a row size");
            //r = Convert.ToInt32(Console.ReadLine());
            //int[] arr = new int[r];
            //Console.WriteLine("enter the values");
            //for (int i = 0; i < r; i++)
            //{
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine("The values are");
            //for (int i = 0; i < r; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}

            //Taking Values are the string

            int r;
            Console.WriteLine("enter a row size");
            r = Convert.ToInt32(Console.ReadLine());
            string[] arr = new string[r];
            Console.WriteLine("enter the values");
            for (int i = 0; i < r; i++)
            {
                arr[i] = Console.ReadLine();
            }
            Console.WriteLine("The values are");
            for (int i = 0; i < r; i++)
            {
                Console.WriteLine(arr[i]);
            }

                Console.ReadLine();
        }
    }
}
