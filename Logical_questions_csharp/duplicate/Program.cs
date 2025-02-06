using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace duplicate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dupl = new int[] { 3, 1, 52, 1, 76, 44 };

            bool[] visited = new bool[dupl.Length];
            

            Console.WriteLine("Duplicate elements: ");
            for (int i = 0; i < dupl.Length; i++)
            {
                
                if (!visited[i])
                {
                    for (int j = i + 1; j < dupl.Length; j++)
                    {
                        if (dupl[i] == dupl[j])
                        {
                            Console.WriteLine(dupl[i]);
                            visited[j] = true;
                            break;
                        }
                    }
                }
            }
        }
    }
}
