using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hashsetexam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();
            set.Add("gth");
            set.Add("fkdjg");
            set.Add("kgri");
            set.Add("jhhhdh");
            set.Add("gth");

            set.GetHashCode();
            foreach (string s in set) 
            { 
                Console.WriteLine(s);
            }
        }
    }
}
