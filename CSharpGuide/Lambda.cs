using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGuide
{
    using System;

    class Lambda
    {
        static void Main11()
        {


                // Lambda to square a number
                Func<int, int> square = x => x * x;

                // Lambda to get the length of a string
                Func<string, int> length = x => x.Length;

                // Lambda to get the max of two numbers
                Func<int, int, int> maxOfTwo = (x, y) => x > y ? x : y;

                // Lambda to check if a string is a palindrome (ignores case and spaces)
                Func<string, bool> isPalindrome = s =>
                {
                    var cleaned = new string(s.Where(char.IsLetterOrDigit).ToArray()).ToLower();
                    return cleaned == new string(cleaned.Reverse().ToArray());
                };

                // Lambda to concatenate two strings
                Func<string, string, string> concatStrings = (s1, s2) => s1 + s2;

                // Lambda to get factorial (not recommended for large numbers due to recursion)
                Func<int, int> factorial = null;
                factorial = x => x == 0 ? 1 : x * factorial(x - 1);

                // Example usage:
                Console.WriteLine(square(5));              // 25
                Console.WriteLine(length("hello"));        // 5
                Console.WriteLine(maxOfTwo(10, 5));        // 10
                Console.WriteLine(isPalindrome("A man a plan a canal Panama"));  // True
                Console.WriteLine(concatStrings("hello", " world"));  // hello world
                Console.WriteLine(factorial(5));           // 120
            }
        }

    }


