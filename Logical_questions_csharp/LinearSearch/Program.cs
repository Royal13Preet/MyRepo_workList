using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearSearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 6, 84, 353, 67, 35, 677, 9 };
            bool found = false;
            int key = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == key)
                {
                    found = true;
                    break;
                }
               
            }

            if (found) 
            {
                Console.WriteLine("the element is there");
            }
            else
            {
                Console.WriteLine("it is not there");
            }
        }
    }
}
