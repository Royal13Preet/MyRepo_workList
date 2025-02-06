using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitwise
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("enter the multiple");
            int a = Convert.ToInt32(Console.ReadLine());
            int bb = a << 2;
            Console.WriteLine(bb);
        }
    }
}
