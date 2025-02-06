using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a = Convert.ToInt32(Console.ReadLine());
            int Count = 0;
            int i;
            for (i = 1; i < a / 2; i++)
            {
                if (a % i == 0)
                {
                    Count++;
                }

            }
            if (Count == 1)
            {
                Console.WriteLine("print prime");
                //Console.WriteLine(i);
            }
            else
            {
                Console.WriteLine("not");
            }

        }
    }
}
