using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment15
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
                // Generate a random array of integers
                int[] array = GenerateRandomArray(10);

                Console.WriteLine("Original Array: " + string.Join(", ", array));

                // Apply Bubble Sort in descending order
                BubbleSortDescending(array);

                Console.WriteLine("Sorted Array: " + string.Join(", ", array));

                // Check if the array is sorted correctly
                bool isSorted = IsArraySorted(array);
                Console.WriteLine("Is Array Sorted Correctly? " + isSorted);

                // Perform Binary Search
                int searchValue = 55;
                int index = BinarySearch(array, searchValue);

                if (index != -1)
                {
                    Console.WriteLine($"Binary Search: {searchValue} found at index {index}");
                }
                else
                {
                    Console.WriteLine($"{searchValue} not found in the array.");
                }
            }

            // Bubble Sort in descending order
            static void BubbleSortDescending(int[] arr)
            {
                int n = arr.Length;
                for (int i = 0; i < n - 1; i++)
                {
                    for (int j = 0; j < n - 1 - i; j++)
                    {
                        if (arr[j] < arr[j + 1])
                        {
                            // Swap elements
                            int temp = arr[j];
                            arr[j] = arr[j + 1];
                            arr[j + 1] = temp;
                        }
                    }
                }
            }

            // Generate a random array of integers
            static int[] GenerateRandomArray(int size)
            {
                Random random = new Random();
                int[] array = new int[size];

                for (int i = 0; i < size; i++)
                {
                    array[i] = random.Next(1, 101); // Random integers between 1 and 100
                }

                return array;
            }

            // Check if the array is sorted correctly
            static bool IsArraySorted(int[] arr)
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] < arr[i + 1])
                    {
                        return false;
                    }
                }
                return true;
            }

            // Binary Search
            static int BinarySearch(int[] arr, int target)
            {
                int left = 0;
                int right = arr.Length - 1;

                while (left <= right)
                {
                    int mid = left + (right - left) / 2;

                    if (arr[mid] == target)
                    {
                        return mid;
                    }
                    else if (arr[mid] > target)
                    {
                        left = mid + 1;
                    }
                    else
                    {
                        right = mid - 1;
                    }
                }

                return -1; // Element not found
            }
        

    }
}

