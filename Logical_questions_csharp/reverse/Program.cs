using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string aa = "i am a good developer";
            string reverse = "";
            for (int i = 0; i < aa.Length; i++)
            {
                reverse = aa[i] + reverse;
            }
            Console.WriteLine(reverse);

        }
    }
}
