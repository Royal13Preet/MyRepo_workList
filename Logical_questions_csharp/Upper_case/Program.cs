using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upper_case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string value = Console.ReadLine();
            string re = "";
            for (int i = 0; i < value.Length; i++)
            {
                if (value[i] >= 65 && value[i] <= 96)
                {
                    re += (char)(value[i] + 32);
                }
                else
                {
                    re += (char)(value[i]);
                }
            }
            Console.WriteLine(re);
            Console.ReadKey();
        }
    }
}
