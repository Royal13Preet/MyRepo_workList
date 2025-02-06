using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace files
{
    internal class Program
    {
       
            static void Main(String[] args)
            {
            int[] arr = { 5,6,53,3,2,5,5};
                method1();
                method2();
                Console.WriteLine("hi from method1");

            }
            static void method1()
            {
                Console.WriteLine("hi from method1");
                Thread.Sleep(500);
                Console.WriteLine("hi from method1 after sleep");
            }
            static void method2()
            {
                Console.WriteLine("hi from method2");
                Thread.Sleep(500);
                Console.WriteLine("hi from method2 after sleep");
            }
           
    }
}
