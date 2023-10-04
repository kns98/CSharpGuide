using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGuide
{
    using System;

    class ModuloMultiply
    {
        // Declaring a global variable as it's going to be used again and again in the function
        static long m;

        static long Modder(long x, long y)
        {
            // x to the power zero is 1
            if (y == 0)
                return 1;
            // x to the power one is x
            else if (y == 1)
                return x;

            // We now split the problem into two parts
            // solve one of them and use its resultant for the second part
            else
            {
                long ans = Modder(x, y / 2);
                // If the power is not divisible by 2, we simply multiply by x
                // Using the concept: (a * b) % m = (a % m * b % m) % m
                // This concept is used repeatedly when y % 2 != 0

                if (y % 2 == 0)
                    return (ans % m) * (ans % m) % m;
                else
                    return ((ans % m) * (ans % m) % m * (x % m)) % m;
            }
        }

        static void Main20()
        {
            Console.WriteLine("Enter three numbers, x to the power of y modulo m: ");
            long x = long.Parse(Console.ReadLine());
            long y = long.Parse(Console.ReadLine());
            m = long.Parse(Console.ReadLine());

            // We don't need to send m here now
            long result = Modder(x, y);

            Console.WriteLine("The resultant is: " + result);
        }
    }

}
