using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace largest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 63, 567889, 2, 62, 1566 };
            int large = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > large)
                {
                    large = arr[i];
                }

            }
            Console.WriteLine(large);
        }
    }
}
