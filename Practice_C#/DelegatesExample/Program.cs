using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesExample
{
    public class Program
    {
       public static int sum(int x, int y)
        {
            return (x + y);
        }
        public static void sub(int x, int y) { 
            Console.WriteLine (x - y);
        }
    }
    public delegate int delegateName(int x, int y);
    public delegate void delegateNamee(int x, int y);
    

    public class test
    {
        static void Main(string[] args)
        {
            

            delegateNamee a = new delegateNamee(Program.sub);
            delegateName b = new delegateName(Program.sum);
            delegateName c = a + b;
            int cc = c(3, 56);
            Console.WriteLine(cc);
            Console.WriteLine(cc);
            
            

            
        }
    }
        
    
}
