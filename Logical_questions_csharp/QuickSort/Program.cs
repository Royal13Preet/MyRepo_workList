using System;
namespace QuickSort
{
    class Program
    {
        static void QuickSort(int[] arr, int low, int high)
        {
                if (low < high)
                {
                    
                    int pivotIndex = Partition(arr, low, high);

                    
                    QuickSort(arr, low, pivotIndex - 1);
                    QuickSort(arr, pivotIndex + 1, high);
                }
            }

            static int Partition(int[] arr, int low, int high)
            {
                int pivot = arr[low];  
                int left = low + 1;
                int right = high;

                while (left <= right)
                {
                    while (left <= right && arr[left] >= pivot)
                    {
                        left++;

                    }

                    
                    while (left <= right && arr[right] <= pivot)
                    {
                        right--;
                    }

                    
                    if (left < right)
                    {
                        int temp = arr[left];
                        arr[left] = arr[right];
                        arr[right] = temp;
                    }
                }

                
                arr[low] = arr[right];
                arr[right] = pivot;

                return right;  
            }

            static void Main()
            {
                int[] arr = { 8,1,9,25,7,54,8,19 };
                int n = arr.Length;

                Console.WriteLine("Original Array:");
                Console.WriteLine(string.Join(", ", arr));

                QuickSort(arr, 0, n - 1);

                Console.WriteLine("Sorted Array:");
                Console.WriteLine(string.Join(", ", arr));
            }
        }

    }

