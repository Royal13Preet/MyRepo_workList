using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Averageprime
{
    public class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            int numcount = 0;
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            for(int j  = 0; j < num; j++)
            {
                int count = 0;

                for (int i = 1; i <= j / 2; i++)
                {
                    if (j % i == 0)
                    {
                        count++; 

                    }
                }
                if (count == 1)
                {
                    total = total + j;
                    numcount++;
                }
            }
            int result = total / numcount;
            Console.WriteLine("the average of prime number is: " +result);
        }
    }
}
