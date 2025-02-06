using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string txt1 = "C#";
            //string txt2 = "preet";

            string txt3 = "preet";
            string txt4 = "preet";

            //string txt5 = "preet";
            //string txt6 = "Preet";

            //bool ab = txt1.Equals(txt2);
            //bool ab2 = txt3.Equals(txt4);
            //bool ab3 = txt5.Equals(txt6);

            //Console.WriteLine(ab);

            //Console.WriteLine(ab2);
            //Console.WriteLine(ab3);

            int ab4 = Convert.ToInt32(object.ReferenceEquals(txt3, txt4));

            //int a = Convert.ToInt32(txt1.Equals(txt2));
            //int b = Convert.ToInt32(txt3.Equals(txt4));
            //int c = Convert.ToInt32(txt5.Equals(txt6));

            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);
            Console.WriteLine(ab4);
        }
    }
}
