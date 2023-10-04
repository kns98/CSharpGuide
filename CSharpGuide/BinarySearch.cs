using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGuide
{
    internal class BinarySearch
    {
 
        static void Main4()
        {
            int[] arr = { 5, 15, 24, 32, 56, 89 };
            int size_of_array = arr.Length;
            Console.WriteLine(RunBinarySearch(arr, 24, 0, size_of_array - 1) ? "1" : "0"); // Check if 24 is in arr
            Console.WriteLine(RunBinarySearch(arr, 118, 0, size_of_array - 1) ? "1" : "0"); // Check if 118 is in arr
        }

        static bool RunBinarySearch(int[] array, int number, int start, int end)
        {
            if (start > end) return false;

            int mid = start + (end - start) / 2; // Avoids overflow, finds middle index

            if (number == array[mid]) return true;

            if (number < array[mid])
                return RunBinarySearch(array, number, start, mid - 1);
            else
                return RunBinarySearch(array, number, mid + 1, end);
        }
    }

}

