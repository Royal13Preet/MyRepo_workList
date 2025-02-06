using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCompConcat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "aaabtdhaebcdaav";
            string compressed = "";
            int count = 1;

            for (int i = 0; i < str1.Length; i++)
            {
                if (i < str1.Length - 1 && str1[i] == str1[i + 1])
                {
                    count++;
                }
                else
                {
                    compressed += str1[i];
                    compressed += count;
                    count = 1;
                }
            }

            Console.WriteLine(compressed);
        }
    }
}
