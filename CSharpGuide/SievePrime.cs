using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGuide
{
    using System;

    class Primes
    {
        static void Main24()
        {
            // Sieve of Eratosthenes is an algorithm for finding all prime numbers up to a given limit.
            // It works by iteratively marking as composite (i.e., not prime) the multiples of each prime, starting with the first prime number, 2.
            const int limit = 100; // size of integers array
            bool[] primes = new bool[limit]; // initializing the array to store prime numbers

            // Initialize the array spaces
            for (int i = 2; i < limit; i++)
                primes[i] = true;

            // Implementing the Sieve of Eratosthenes
            for (int i = 2; i < limit; i++)
            {
                if (primes[i])
                {
                    // Marking the multiples of found prime number as not prime
                    for (int j = i; i * j < limit; j++)
                        primes[i * j] = false;
                }
            }

            // Printing the prime numbers in the range from 1 to 100
            Console.WriteLine("Prime numbers in range 1 to 100 are: ");
            for (int i = 2; i < limit; i++)
            {
                if (primes[i])
                    Console.WriteLine(i);
            }
        }
    }

}
