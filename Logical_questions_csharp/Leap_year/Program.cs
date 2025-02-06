using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leap_year
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a leap year");
            int yaer = Convert.ToInt32(Console.ReadLine());
            if (yaer % 4 == 0 && yaer % 100 != 0 || yaer % 400 == 0)
            {
                Console.WriteLine("Leap year");
            }
            else
            {
                Console.WriteLine("not");
            }
        }
    }
}
