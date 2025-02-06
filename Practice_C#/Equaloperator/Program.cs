using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equaloperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "hello";
            string myname = name;
            Console.WriteLine($"==: {0} ", name == myname);

         
            Console.WriteLine($"equals: {0} ", myname.Equals(name));
        }
    }
}
