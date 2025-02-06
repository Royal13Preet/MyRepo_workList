using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareTo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string txt1 = "C#"; //smaller
            string txt2 = "preet"; //bigger

            string txt3 = "preet";
            string txt4 = "preet";

            string txt5 = "Preet";
            string txt6 = "preet";

            int result = String.Compare(txt1, txt2);
            int result1 = String.Compare(txt3, txt4);
            int result2 = String.Compare(txt5, txt6);

            Console.WriteLine(result);
            Console.WriteLine(result1);
            Console.WriteLine(result2);
        }
    }
}
