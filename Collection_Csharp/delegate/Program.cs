using System;
using System.Threading;

namespace DelegateExample
{
    class Program
    {
        
        //public static void Addi(int x, int y)
        //{
        //    Console.WriteLine(x + "," + y);
        //}
        public static void Add(int x, int y)
        {
            Console.WriteLine($"Sum: {x + y}");
            Thread.Sleep(9000);
        }

        public static int Sub(int x, int y, int z)
        {
            return x - y - z;
        }
        
        public delegate void Dname(int x, int y); 
        public delegate int Name(int x, int y, int z);
    }

    class Test
    {
        public static void Main(string[] args)
        {
            
            Program.Dname obj = new Program.Dname(Program.Add);
            Program.Name obj1 = new Program.Name(Program.Sub);

            
            obj(89, 9);

            
            int result = obj1(20, 50, 40);
            Console.WriteLine($"Result of subtraction: {result}");

            
            Thread thread = new Thread(() => Program.Sub(10, 20,5)); 
            thread.Start();
        }
    }
}
