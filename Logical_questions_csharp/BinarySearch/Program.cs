using System;

namespace BinarySearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 5, 23, 34, 53 }; 
            int target = 23;
            int result = BinarySearch(arr, target);
            if (result != -1)
            {
                Console.WriteLine($"Element found at index {result}");
            }
            else
            {
                Console.WriteLine("Element not found in the array");
            }
             Console.ReadLine();
        }
        static int BinarySearch(int[] arr, int target)
        {
            int left = 0;
            int rigth = arr.Length - 1;
            while (left <= rigth)
            {
                int mid = left + (rigth - left) / 2;

                if (arr[mid] == target)
                {
                    return mid;
                }

                if (arr[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    rigth = mid - 1;
                }

            }

            
            return -1;
        }
    }
}
