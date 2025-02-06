using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectNumber
{
    public class Program
    {
        static void Main(string[] args)
        {
            int number, i, sum = 0;
            Console.Write("Enter a Number :");
            number = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= number / 2; i++)
            {
                if (number % i == 0)
                    sum += i;
            }

            if (sum == number && number != 0)
                Console.WriteLine($"{number} is a Perfect Number");
            else
                Console.WriteLine($"{number} is not a Perfect Number");
            Console.ReadKey();

            
        }
    }
}
  