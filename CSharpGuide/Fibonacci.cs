using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGuide
{
    using System;

    class Fibonacci
    {
        // fib method with argument n to generate nth Fibonacci Number
        static int Fib(int n)
        {
            // Base case defined
            if (n <= 1)
                return n;

            // Recursive Calls to Fib method
            return Fib(n - 1) + Fib(n - 2);
        }

        static void Main21()
        {
            // Sample input
            int n = 11;

            // Printing the nth Fibonacci Number
            Console.WriteLine(Fib(n));
        }
    }

}
