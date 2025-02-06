using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeyear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TimeZone timeZone = TimeZone.CurrentTimeZone;
            //DateTime local = timeZone.ToLocalTime(DateTime.Now);
            //Console.WriteLine("The Local Time is :{0}", local);
            //Console.ReadLine();

            Console.WriteLine("Enter the number of rows");
            int row = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= row; i++)
            {
                for(int j = i; j<row; j++)
                {
                    Console.Write(" ");
                }
                for(int j = 1; j<= (2*i-1); j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for(int i = row-1; i >= row; i--)
            {
                for(int j =row;  j > i; j--)
                {
                    Console.Write(" ");
                }
                for(int j = 1; j <= (2 * i - 1); j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }
}
 
