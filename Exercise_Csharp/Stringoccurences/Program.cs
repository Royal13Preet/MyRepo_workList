using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stringoccurences
{
    public class Program
    {
        static void Main(string[] args)
        {
            using System;

class Program
        {
            static int CountOccurrences(string substring, string mainString)
            {
                int count = 0;
                int index = mainString.IndexOf(substring);

                while (index != -1)
                {
                    count++;
                    index = mainString.IndexOf(substring, index + 1); // Move to the next occurrence
                }

                return count;
            }

            static void Main()
            {
                Console.Write("Enter the main string: ");
                string mainString = Console.ReadLine();

                Console.Write("Enter the substring: ");
                string substring = Console.ReadLine();

                int result = CountOccurrences(substring, mainString);
                Console.WriteLine($"Occurrences of '{substring}' in '{mainString}': {result}");
            }
        }
    }
    }
}
