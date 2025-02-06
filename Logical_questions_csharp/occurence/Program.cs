using System;
using System.Collections.Generic;

namespace Occurrence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string occur = Console.ReadLine();
            Dictionary<char, int> charCount = new Dictionary<char, int>();

            foreach (char c in occur)
            {
                if (charCount.ContainsKey(c))
                {
                    charCount[c]++;
                }
                else
                {
                    charCount[c] = 1;
                }
            }

            foreach (var item in charCount)
            {
                Console.WriteLine("Character: " + item.Key + " Count: " + item.Value);
            }
        }
    }
}
