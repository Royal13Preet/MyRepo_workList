using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
   
    class abc
    {
        public static void a()
        {
            Console.WriteLine("first method");
        }
        public void b()
        {
            a();
            Console.WriteLine("second method");
        }
        public void b(int i)
        {
            Console.WriteLine(i);
            b();
        }
    }
    class program
    {
        static void Main()
        {
            abc k = new abc();
            abc.a();
            k.b(20);
        }
            
        
    }
}

