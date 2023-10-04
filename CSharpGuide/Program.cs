using HelloDotNetGuide.CommonAlgorithms;
using HelloDotNetGuide.ArrayRelated;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloDotNetGuide.ArrayRelated
{
    /// <summary>
    /// Common ways to deduplicate C# array data
    /// </summary>
    public class ArrayDeduplication
    {
        /// <summary>
        /// Deduplicate using HashSet
        /// TODO: HashSet is a collection class that does not allow duplicate elements and can easily achieve deduplication.
        /// </summary>
        public static void HashSetDuplicate()
        {
            var dataSource = new List<int>() { 1, 2, 3, 2, 5, 88, 99, 99, 100, 88, 30, 50, 15, 100, 99, 99, 2, 3 };
            HashSet<int> uniqueData = new HashSet<int>(dataSource);
            Console.WriteLine(string.Join(", ", uniqueData));
        }
        /// <summary>
        /// Deduplicate using Linq's Distinct() method
        /// </summary>
        public static void DistinctDuplicate()
        {
            var dataSource = new List<int>() { 1, 2, 3, 2, 5, 88, 99, 99, 100, 88, 30, 50, 15, 100, 99, 99, 2, 3 };
            var uniqueData = dataSource.Distinct();
            Console.WriteLine(string.Join(", ", uniqueData));
        }
        /// <summary>
        /// Deduplicate using Linq's GroupBy() method
        /// </summary>
        public static void GroupByDuplicate()
        {
            var dataSource = new List<int>() { 1, 2, 3, 2, 5, 88, 99, 99, 100, 88, 30, 50, 15, 100, 99, 99, 2, 3 };
            // GroupBy() method groups the elements in the original collection based on a specified key or condition.
            // Each group will have a unique key, and deduplication is achieved by grouping the original collection
            // and selecting the first element from each group.
            var uniqueData = dataSource.GroupBy(item => item).Select(group => group.First()).ToList();
            Console.WriteLine(string.Join(", ", uniqueData));
        }
        /// <summary>
        /// Deduplicate using a custom comparer and loop traversal
        /// </summary>
        public static void CustomEqualityComparerDuplicate()
        {
            var dataSource = new List<int>() { 1, 2, 3, 2, 5, 88, 99, 99, 100, 88, 30, 50, 15, 100, 99, 99, 2, 3 };
            var uniqueData = new List<int>();
            foreach (var item in dataSource)
            {
                if (!uniqueData.Contains(item, new CustomEqualityComparer()))
                {
                    uniqueData.Add(item);
                }
            }
            Console.WriteLine(string.Join(", ", uniqueData));
        }
        /// <summary>
        /// Deduplicate using direct loop traversal
        /// </summary>
        public static void LoopTraversalDuplicate()
        {
            var dataSource = new List<int>() { 1, 2, 3, 2, 5, 88, 99, 99, 100, 88, 30, 50, 15, 100, 99, 99, 2, 3 };
            var uniqueData = new List<int>();
            foreach (var item in dataSource)
            {
                //if (!uniqueData.Any(x => x == item))
                //if (!uniqueData.Exists(x => x == item))
                if (!uniqueData.Contains(item))
                {
                    uniqueData.Add(item);
                }
            }
            Console.WriteLine(string.Join(", ", uniqueData));
        }
    }
    /// <summary>
    /// Custom comparer
    /// </summary>
    public class CustomEqualityComparer : IEqualityComparer<int>
    {
        public bool Equals(int x, int y)
        {
            return x == y;
        }
        public int GetHashCode(int obj)
        {
            return obj.GetHashCode();
        }
    }
}
//*** SourceCombiner -> original file List集合相关算法.cs ***
namespace HelloDotNetGuide.CommonAlgorithms
{
    public class ListCollectionRelatedAlgorithms
    {
        /// <summary>
        /// Get the list data after removal
        /// Topics Covered: C# List RemoveAt (remove by index), Remove (remove by object)
        /// </summary>
        /// <returns></returns>
        public static List<int> GetAfterRemoveListData()
        {
            List<int> list = new List<int>();
            for (int i = 1; i <= 10; i++)
            {
                list.Add(i);
            }
            for (int i = 0; i < 5; i++)
            {
                list.RemoveAt(i);// Remove by index: Output will be: 2, 4, 6, 8, 10
                list.Remove(i);// Remove by object: Output will be: 5, 6, 7, 8, 9, 10
            }
            // When both are used together, the output will be: 6, 7, 9
            return list;
        }
    }
}

namespace HelloDotNetGuide
{
    internal class Program
    {
        static void _Main(string[] args)
        {
            Console.WriteLine("Welcome to the DotNetGuide practice space!!!");
            #region Common Algorithms
            ShellSortAlgorithm.ShellSortRun();
            // InsertionSortAlgorithm.InsertionSortRun();
            // QuickSortAlgorithm.QuickSortRun();
            // RecursiveBubbleSortAlgorithm.RecursiveBubbleSortRun();
            // ListCollectionRelatedAlgorithms.GetAfterRemoveListData();
            // SelectionSortAlgorithm.SelectionSortAlgorithmMain();
            #endregion
            #region Array Related
            // ArrayDeduplication.LoopTraversalDuplicate();
            #endregion
        }
    }
}

//*** SourceCombiner -> original file ShellSortAlgorithm.cs ***
namespace HelloDotNetGuide.CommonAlgorithms
{
    public class ShellSortAlgorithm
    {
        public static void ShellSort(int[] array)
        {
            int arrLength = array.Length;
            // Initialize the gap (initial interval) to half the length of the array
            int gap = arrLength / 2;
            // Continuously reduce the gap until it becomes 1
            while (gap > 0)
            {
                // Perform insertion sort on each subsequence
                for (int i = gap; i < arrLength; i++)
                {
                    int temp = array[i];
                    int j = i;
                    // Perform insertion sort within the subsequence
                    while (j >= gap && array[j - gap] > temp)
                    {
                        array[j] = array[j - gap];
                        j -= gap;
                    }
                    array[j] = temp;
                }
                // Reduce the gap
                gap /= 2;
            }
        }
        public static void ShellSortRun()
        {
            int[] array = { 19, 20, 22, 32, 34, 50, 99, 49, 1, 11, 11, 55, 35, 93, 96, 71, 70, 38, 78, 48 };
            Console.WriteLine("Original array: " + string.Join(", ", array));
            ShellSort(array);
            Console.WriteLine("Sorted array: " + string.Join(", ", array));
        }
    }
}
//*** SourceCombiner -> original file QuickSortAlgorithm.cs ***
namespace HelloDotNetGuide.CommonAlgorithms
{
    public class QuickSortAlgorithm
    {
        public static void Sort(int[] array, int low, int high)
        {
            if (low < high)
            {
                // Partition the array into two parts and return the index of the partition point
                int pivotIndex = Partition(array, low, high);
                // Recursively sort the two parts
                Sort(array, low, pivotIndex - 1);
                Sort(array, pivotIndex + 1, high);
            }
        }
        private static int Partition(int[] array, int low, int high)
        {
            // Choose the last element as the pivot
            int pivot = array[high];
            int i = low - 1;
            for (int j = low; j <= high - 1; j++)
            {
                // If the current element is less than or equal to the pivot element, swap it with the element at i+1 position
                if (array[j] <= pivot)
                {
                    i++;
                    Swap(array, i, j);
                }
            }
            // Place the pivot element in its correct position
            Swap(array, i + 1, high);
            return i + 1; // Return the index of the pivot element
        }
        private static void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
        public static void QuickSortRun()
        {
            int[] array = { 2, 3, 5, 38, 19, 15, 26, 27, 36, 44, 47, 46, 50, 48, 4 };
            Sort(array, 0, array.Length - 1);
            Console.WriteLine("Sorted result: " + string.Join(", ", array));
        }
    }
}
//*** SourceCombiner -> original file InsertionSortAlgorithm.cs ***
namespace HelloDotNetGuide.CommonAlgorithms
{
    public class InsertionSortAlgorithm
    {
        public static void InsertionSort(int[] array)
        {
            int arrayLength = array.Length;
            for (int i = 1; i < arrayLength; ++i)
            {
                // Define a temporary variable
                int temp = array[i];
                int j = i - 1;
                while (j >= 0 && array[j] > temp)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = temp;
            }
        }
        public static void InsertionSortRun()
        {
            int[] array = { 26, 15, 5, 3, 38, 36, 44, 27, 47, 2, 46, 4, 50, 19, 48 };
            Console.WriteLine("Before sorting: " + string.Join(", ", array));
            InsertionSort(array);
            Console.WriteLine("After sorting: " + string.Join(", ", array));
        }
    }
}
//*** SourceCombiner -> original file SelectionSortAlgorithm.cs ***
namespace HelloDotNetGuide.CommonAlgorithms
{
    public class SelectionSortAlgorithm
    {
        // Selection Sort is a simple sorting algorithm with the following steps:
        // 1. Traverse the input array, starting from the first element.
        // 2. Assume the current element is the minimum, and save its index as the minimum index (minIndex).
        // 3. In the remaining unsorted part of the array, find an element that is smaller than the current minimum element, and update the minimum index.
        // 4. After the traversal, swap the minimum element with the element at the current position.
        // 5. Repeat steps 2-4 for the entire array until it is sorted.
        // The time complexity of the Selection Sort algorithm is O(n^2), where n is the size of the input array. Although it has a higher time complexity compared to some advanced sorting algorithms, Selection Sort is simple to understand and can perform well on small arrays.
        /// <summary>
        /// Selection Sort Algorithm
        /// </summary>
        public static void SelectionSortAlgorithmMain()
        {
            int[] array = { 64, 25, 12, 22, 11, 99, 3, 100 };
            Console.WriteLine("Original array: ");
            PrintArray(array);
            RunSelectionSortAlgorithm(array);
            Console.WriteLine("Sorted array: ");
            PrintArray(array);
        }
        static void RunSelectionSortAlgorithm(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                // Find the index of the minimum element in the unsorted part
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }
                // Swap the minimum element with the element at the current position
                int temp = arr[minIndex];
                arr[minIndex] = arr[i];
                arr[i] = temp;
            }
        }
        static void PrintArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
