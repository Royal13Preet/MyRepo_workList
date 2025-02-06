using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string s1 = "acu";
            string s2 = "uca";
            int i1 = 0;
            int j1 = 0;
            if (s1.Length == s2.Length)
            {
                for (int i = 0; i < s1.Length; i++)
                {
                    for (int j = 0; j < s2.Length; j++)
                    {

                        if (s1[i] == s2[j])
                        {
                            i1 += s1[i];
                            j1 += s2[j];
                        }
                    }
                }
                if (i1 == j1 && i1 != 0 || j1 != 0)
                {
                    Console.WriteLine("the anagram");

                }
                else
                {
                    Console.WriteLine("not");
                }
            }
        }
    }
}
