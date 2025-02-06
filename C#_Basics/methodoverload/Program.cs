using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace methodoverload
{
    class Program
    {
        public int Add(int a, int b)
        {
            int sum = a + b;
            return sum;
        }

        public int Add(int a, int b, int c)
        {
            int sub = a + b + b;
            return sub;
        }

        public float Add(float a, int b) {
            return (float)a + b;

        }
        public string Add(string a, string b)
        {
            return (a + b);

        }
        public long Add(int a,long b, long c)
        {
            return  a + b * c;
        }

        public string Add(int a, string b)
        {
            return (a + b);
        }

        public long Add(int a, long b,int c) { 
            return a + b;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            long a = p.Add(2, 4,8);
            Console.WriteLine(a);
            float b = p.Add(3.7f,5);
            Console.WriteLine(b);
            string c = p.Add("pree", "gowda");
            Console.WriteLine(c);
            float d = p.Add(4,444444L,6);
            Console.WriteLine(d);
            string e = p.Add(4, "pree");
            Console.WriteLine(e);
            string f = p.Add(4, "7");
            Console.WriteLine(f);
            Console.ReadKey();
        }
    }
}
