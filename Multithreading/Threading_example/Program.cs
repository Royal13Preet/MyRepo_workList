using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThraedaingExa_ple
{
   
    class Program
    {
        static void Main()
        {
            Thread thread1 = new Thread(PrintNumbers);
            Thread thread2 = new Thread(PrintNumbers);
            thread1.Start();
            thread2.Start();
            //thread1.Join();
            //thread2.Join();
        }
        static void PrintNumbers()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId}: {i}");
                Thread.Sleep(500); 
            }
        }
    }
}

