using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Anonymousmethods
{
    public class Program
    {
        public delegate string delagename(string name);
        
        public static string Method(string name)
        {
            return "hi" + name;
        }
        static void Main(string[] args)
        {
            delagename obj = delegate (string name) { return "hi" + name; };
            string a =obj("preet");
            Console.WriteLine(a);
            
        }
    }
}
