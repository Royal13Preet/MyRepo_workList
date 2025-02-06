using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace wordoccurence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string occurence = "I am a python am a developer";
            string[] occur1 = occurence.Split(' ');
            Dictionary<string, int> wordoccur = new Dictionary<string, int>();

            foreach (string i in occur1)
            {
                if (wordoccur.ContainsKey(i)) 
                {
                    wordoccur[i]++;

                }
                else
                {
                    wordoccur[i] = 1;
                }
            }
            foreach (var item in wordoccur)
            {
                Console.WriteLine("charcter " +item.Key+ " Count :" + item.Value );
            }

        }
    }

}



