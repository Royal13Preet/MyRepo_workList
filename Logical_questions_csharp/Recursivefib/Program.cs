using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursivefib
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine("enter a number");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++) {
                Console.WriteLine(i);
            }
        }
        public int fib(int num)

        {
            if (num <= 1)
            {
                return 0;
            }
            else
            {
                return fib(num - 1) + fib(num-1);
            }
        }
    }
}
