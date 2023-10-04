using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGuide
{
    using System;

    class LcmGcd
    {
        // Method to calculate the Greatest Common Divisor using Euclidean Algorithm
        static long GetGcdEuclidean(long a, long b)
        {
            // If b is greater than a, swap the values
            if (b > a)
            {
                var temp = a;
                a = b;
                b = temp;
            }

            // If b is 0, return a as the GCD
            if (b == 0)
                return a;

            // Calculate the remainder of a divided by b
            var remainder = a % b;

            // Recursive call to continue the Euclidean Algorithm
            return GetGcdEuclidean(b, remainder);
        }

        // Method to calculate the Least Common Multiple using the Euclidean Algorithm to find the GCD
        static long GetLcmEuclidean(long val1, long val2)
        {
            // If either of the values is 0, return 0 as the LCM
            if (val1 == 0 || val2 == 0)
                return 0;

            // Calculate the product of the two values
            long prod = val1 * val2;

            // Calculate the GCD of the two values
            long gcd = GetGcdEuclidean(val1, val2);

            // Return the product divided by the GCD as the LCM
            return prod / gcd;
        }

        // Main method where execution starts
        static void Main12()
        {
            // Read two long integers from the user
            if (long.TryParse(Console.ReadLine(), out long ip1) && long.TryParse(Console.ReadLine(), out long ip2))
                // Print the LCM of the two numbers to the console
                Console.WriteLine(GetLcmEuclidean(ip1, ip2));
            else
                // Print an error message if the input is invalid
                Console.WriteLine("Invalid input, please enter two valid long integers.");
        }
    }

}
