using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();

        }
    }
}
