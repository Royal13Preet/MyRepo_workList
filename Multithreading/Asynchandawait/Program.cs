using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Asynchandawait
{
    public class Program
    {
        static async void method1()
        {
            Console.WriteLine("gdutgu");
            await Task.Delay(1000);
            Console.WriteLine("After a sleep");
        }

        static void method2()
        {
            Console.WriteLine("Hii");
            //Thread.Sleep(1000);
            Console.WriteLine("After uh sleep");
        }
        static void Main(string[] args) {
            method1();
            method2();
            
        }
    }
}
