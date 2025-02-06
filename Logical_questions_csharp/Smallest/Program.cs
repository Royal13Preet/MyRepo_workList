using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smallest
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] arr = { 758, 85, 95, 9, 8, 2, 9, 56788 };
            int small = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < small)
                {
                    small = arr[i];
                }
            }
            Console.WriteLine("the smallest" + small);
            int secondsmall = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != small)
                {
                    if (arr[i] < secondsmall)
                    {
                        secondsmall = arr[i];
                    }
                }
            }
            Console.WriteLine("the second smallest" + secondsmall);
        }
    }
}
