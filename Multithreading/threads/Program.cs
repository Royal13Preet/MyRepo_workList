using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace threads
{
    internal class Program
    {
        public static void h()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
            }

        }

        public static void m2()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
            }
        }


    }

    public class jj
    {
        public static void Main(string[] args) {

            
            Thread hj = new Thread(Program.h);


        
        }
    }
}