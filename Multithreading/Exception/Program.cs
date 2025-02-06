using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptionexample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                try
                {
                    int[] arr = { 5, 6, 3, 5 };
                    for (int i = 0; i < arr.Length; i++)
                    {
                        Console.WriteLine(arr[i]);

                    }
                }
                catch (IndexOutOfRangeException e)
                {
                    throw new Exception("human error", e); 
                }


            }
        }
    }
}

          
  