using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayfun
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 2, 8, 9, 4, 6 };

            if (arr.IsFixedSize)
            {
                Console.WriteLine("Array is of fixed size");
                Console.WriteLine("Array Size :" + arr.Length);
                Console.WriteLine("Rank :" + arr.Rank);
            }

            if (arr.IsReadOnly)
                Console.WriteLine("Array is read-only");
            else
                Console.WriteLine("Array is not read-only");
        }
    }
}
 