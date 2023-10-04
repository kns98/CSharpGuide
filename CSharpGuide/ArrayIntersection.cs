using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGuide
{
    using System;
    using System.Collections.Generic;

    class ArrayEx
    {
        static void Main19()
        {
            Console.WriteLine("Enter the number of elements in the arrays");
            if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive integer.");
                return;
            }

            int[] array1 = new int[n];
            int[] array2 = new int[n];

            Console.WriteLine("Enter the elements of the 1st array");
            for (int i = 0; i < n; i++)
            {
                if (!int.TryParse(Console.ReadLine(), out array1[i]))
                {
                    Console.WriteLine("Invalid input. Please enter an integer.");
                    return;
                }
            }

            Console.WriteLine("Enter the elements of the 2nd array");
            for (int i = 0; i < n; i++)
            {
                if (!int.TryParse(Console.ReadLine(), out array2[i]))
                {
                    Console.WriteLine("Invalid input. Please enter an integer.");
                    return;
                }
            }

            Console.WriteLine("The common numbers are:");
            foreach (var item1 in array1)
            {
                foreach (var item2 in array2)
                {
                    if (item1 == item2)
                    {
                        Console.WriteLine(item1);
                        break;
                    }
                }
            }
        }
    }

}
