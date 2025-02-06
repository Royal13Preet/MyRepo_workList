using System;

namespace removeduplicate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 2, 34, 53, 2, 23, 5, 34 };
            int[] arr1 = new int[arr.Length]; 
            int pop = 0; 

            for (int i = 0; i < arr.Length; i++)
            {
                bool isDuplicate = false;

                
                for (int j = 0; j < pop; j++)
                {
                    if (arr[i] == arr1[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }

                
                if (!isDuplicate)
                {
                    arr1[pop] = arr[i];
                    pop++;
                }
            }

          
            Console.WriteLine("Array after removing duplicates:");
            for (int i = 0; i < pop; i++)
            {
                Console.Write(arr1[i] + " ");

                
            }
            Console.ReadLine();
        }
    }
}
