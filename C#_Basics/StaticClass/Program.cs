using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClass
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 5, b = 10;
            if (Convert.ToBoolean(Convert.ToInt32(++a)) || Convert.ToBoolean(Convert.ToInt32(++b)))
            {
                Console.WriteLine(a + "\n" + b);
            }
            else
                Console.WriteLine(" C# ");
        }
    }
}
