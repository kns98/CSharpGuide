using System;
using System.Linq;

namespace CSharpGuide
{
    internal class StringManipulation
    {
        static void Main_()
        {
            // 1. **String Splitting**
            var arr1 = "a,b,c".Split(',');
            Console.WriteLine(string.Join(" ", arr1)); // a b c
            var arr2 = "ambmc".Split('m');
            Console.WriteLine(string.Join(" ", arr2)); // a b c

            // Splitting into specified numbers of substrings.
            var arr3 = "a,b,c".Split(new char[] { ',' }, 2);
            Console.WriteLine(string.Join(" ", arr3)); // a b,c

            // 2. **Conditional Splitting & Fields**
            // Demonstrates how to split strings based on custom conditions 
            // and by spaces using string.Split, merging multiple spaces.

            // 3. **String Joining & Repeating**
            var sce = new[] { "aa", "bb", "cc" };
            var str1 = string.Join("-", sce);
            Console.WriteLine(str1); // aa-bb-cc
            var str2 = string.Concat(Enumerable.Repeat("abc", 2));
            Console.WriteLine(str2); // abcabc

            // 4. **String Replacing**
            var str3 = "abcdefabcdefabc";
            var str4 = str3.Replace("abc", "mmm");
            Console.WriteLine(str3); // abcdefabcdefabc
            Console.WriteLine(str4); // mmmdefmmmdefmmm
        }
    }
}
