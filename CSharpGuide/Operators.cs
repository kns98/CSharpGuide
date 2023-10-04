using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGuide
{

    class SampleOp
    {
        static void Main32()
        {
            // Modulus operation
            int num = 12;
            int divisor = 5;
            int quotient = num / divisor; // This will be 2 (12 / 5 = 2 R 2)
            int remainder = num % divisor; // This will be 2 (the remainder of 12 / 5)

            Console.WriteLine($"For {num} divided by {divisor}:");
            Console.WriteLine($"Quotient is {quotient}");
            Console.WriteLine($"Remainder is {remainder}\n");

            // Increment/Decrement operation
            int preIncrement, postIncrement;
            int value = 5;

            preIncrement = ++value; // Here the value is increased before assignment
            Console.WriteLine($"Pre-Increment: {preIncrement}");

            value = 5; // Resetting value
            postIncrement = value++; // Here the value is increased after assignment
            Console.WriteLine($"Post-Increment: {postIncrement}\n");

            // Logical operators
            bool a = true;
            bool b = false;

            Console.WriteLine($"NOT a: {!a}");
            Console.WriteLine($"a AND b: {a & b}");
            Console.WriteLine($"a OR b: {a | b}");
            Console.WriteLine($"a XOR b: {a ^ b}");

            // To understand more about logical operators, refer to the truth tables
        }
    }

}
