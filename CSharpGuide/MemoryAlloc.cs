using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGuide
{
    using System;

    class Malloc
    {
        static void Main7()
        {
            int initialSize = 10;
            int[] array = new int[initialSize];

            // fill the array with some data for illustration purposes
            for (int i = 0; i < initialSize; i++)
            {
                array[i] = i;
            }

            Console.WriteLine("Initial array:");
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            int newSize = 20;
            int[] newArray = new int[newSize];
            Array.Copy(array, newArray, array.Length);
            array = newArray;

            // fill the new space in the array with some data for illustration purposes
            for (int i = initialSize; i < newSize; i++)
            {
                array[i] = i;
            }

            Console.WriteLine("Resized array:");
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }

}
