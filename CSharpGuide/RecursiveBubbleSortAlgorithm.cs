/*
 * Recursive Bubble Sort has no performance/implementation advantages, but can be a good question to 
 * check one’s understanding of Bubble Sort and recursion.
 * If we take a closer look at Bubble Sort algorithm, we can notice that in first pass, we move largest element 
 * to end (Assuming sorting in increasing order). In second pass, we move second largest element to second last position and so on. 
 * Recursion Idea.  

    Base Case: If array size is 1, return.
    Do One Pass of normal Bubble Sort. This pass fixes last element of current subarray.
    Recur for all elements except last of current subarray.
*/

namespace HelloDotNetGuide.CommonAlgorithms
{
    public class RecursiveBubbleSortAlgorithm
    {
        /// <summary>
        /// Implement bubble sort using double loops
        /// </summary>
        public static void BubbleSort(int[] arr)
        {
            //int[] arr = { 1, 8, 9, 5, 6, 2, 3, 4, 7 };
            int arrLength = arr.Length;
            for (int i = 0; i < arrLength - 1; i++)
            {
                for (int j = 0; j < arrLength - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        // Swap the values of arr[j] and arr[j+1]
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            
        }
        /// <summary>
        /// Implement bubble sort using recursion
        /// </summary>
        /// <param name="arr">arr</param>
        /// <param name="arrLength">arrLength</param>
        public static void RecursiveBubbleSort(int[] arr, int arrLength)
        {
            if (arrLength == 1)
                return;
            for (int i = 0; i < arrLength - 1; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    // Swap the values of arr[i] and arr[i+1]
                    int temp = arr[i];
                    arr[i] = arr[i + 1];
                    arr[i + 1] = temp;
                }
            }
            RecursiveBubbleSort(arr, arrLength - 1);
        }
        public static void Main26()
        {
            int[] arr = GenerateRandomArray(100, 1, 10000); 
            BubbleSort(arr);
            Console.WriteLine("Bubble Sort Sorted result: " + string.Join(", ", arr));

            Console.WriteLine();
            Console.WriteLine();

            arr = GenerateRandomArray(100, 1, 10000);
            RecursiveBubbleSort(arr, arr.Length);
            Console.WriteLine("Recursive Bubble Sort Sorted result: " + string.Join(", ", arr));
        }

        public static int[] GenerateRandomArray(int length, int minValue, int maxValue)
        {
            Random random = new Random();
            int[] arr = new int[length];
            for (int i = 0; i < length; i++)
            {
                arr[i] = random.Next(minValue, maxValue + 1);
            }
            return arr;
        }
    }
}
