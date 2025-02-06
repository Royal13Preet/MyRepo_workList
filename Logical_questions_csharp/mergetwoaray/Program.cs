using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mergetwoaray
{
    internal class Program
    {
      
        public static int[] MergeSortedArrays(int[] arr1, int[] arr2)
        {
            
            int i = 0, j = 0;
            
            int[] mergedArray = new int[arr1.Length + arr2.Length];
            int k = 0;

            
            while (i < arr1.Length && j < arr2.Length)
            {
                if (arr1[i] < arr2[j])
                {
                    mergedArray[k++] = arr1[i++];
                }
                else
                {
                    mergedArray[k++] = arr2[j++];
                }
            }

            // If there are remaining elements in arr1, add them to mergedArray
            while (i < arr1.Length)
            {
                mergedArray[k++] = arr1[i++];
            }

            // If there are remaining elements in arr2, add them to mergedArray
            while (j < arr2.Length)
            {
                mergedArray[k++] = arr2[j++];
            }

            return mergedArray;
        }

        public static void Main()
        {
            int[] arr1 = { 1, 3, 5, 7 };
            int[] arr2 = { 2, 4, 6, 8 };
            int[] mergedArray = MergeSortedArrays(arr1, arr2);

            Console.WriteLine("Merged Array: " + string.Join(", ", mergedArray));
        }
    }

    }


