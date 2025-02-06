using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of rows: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= (2 * i - 1); j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = n - 1; i >= 1; i--)
            {
                for (int j = n; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= (2 * i - 1); j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }


    }

    class jou
    {
        static void main(string[] args)
        {
            Console.WriteLine("enter the number of rows");
            int row =  int.Parse(Console.ReadLine());
            for(int i = 1; i<=row; i++)
            {
                for (int j = i; j<row; j++)
                {

                }
            }
        }
    }
}

