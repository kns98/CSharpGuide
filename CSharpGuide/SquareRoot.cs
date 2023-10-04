using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGuide
{
    using System;

    class SqRoot
    {
        const double MaxError = 1e-7; // equivalent to 10^-7 -> accurate up to 7 decimal places

        static void Main31()
        {
            Console.WriteLine("Enter the number for which you want to compute the square root:");
            if (int.TryParse(Console.ReadLine(), out int num))
            {
                Console.WriteLine($"{SquareRoot(num):F7}");
            }
            else
            {
                Console.WriteLine("Invalid Input. Please enter a valid number.");
            }
        }

        static double SquareRoot(int x)
        {
            double r = 1; // initial guess for the root
            while (Math.Abs(r * r - x) > MaxError)
            {
                r = (r + x / r) / 2;
            }

            return r;
        }
    }

}
