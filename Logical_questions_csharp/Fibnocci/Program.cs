using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Fibnocci
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int fib = Convert.ToInt32(Console.ReadLine());
            int a = 0;
            int b = 1;
            int res = 0;
            for (int i = 0; i < fib; i++)
            {

                Console.WriteLine(a);
                res = a + b;
                a = b;
                b = res;
                //Console.WriteLine(res);
            }
        }
    }
}
