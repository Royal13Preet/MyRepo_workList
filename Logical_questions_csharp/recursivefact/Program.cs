using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace recursivefact
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the fact no");
            int n = Convert.ToInt32(Console.ReadLine());

            Program f = new Program();
            int result = f.fact(n);
            Console.WriteLine($"the factorial of {n} is {result}");

        }
        public int fact(int num)
        {
            if(num <= 1)
            {
                return 1;
            }
            else
            {
                return num * fact(num-1);
            }
        }
    }
    
}
