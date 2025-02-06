using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace PhoneBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create new stopwatch
            Stopwatch stopwatch = new Stopwatch();
            // Begin timing
            stopwatch.Start();
            for (int i = 0; i < 60; i++)
            {
                Console.WriteLine("HI");
            }

            // Stop timing
            stopwatch.Stop();
            Console.WriteLine("Time Elapsed : {0}",
                stopwatch.Elapsed);
            Console.ReadLine();
        }
    }


}
    