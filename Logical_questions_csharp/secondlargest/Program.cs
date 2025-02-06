using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secondlargest
{
    internal class Program
    {
        static void Main(string[] args)
        {

           int[] arr = { 758, 85, 95, 9, 9, 56788 };
            int largest = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > largest)
                {
                    largest = arr[i];
                }
            }
            int secondLargest = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != largest)
                {
                    if (arr[i] > secondLargest)
                    {
                        secondLargest = arr[i];

                    }
                }
            }
            Console.WriteLine("The second largest element is: " + secondLargest);
        }
    }
}
