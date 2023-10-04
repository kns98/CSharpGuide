using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGuide
{
    using System;

    class SubStringSearch
    {
        static bool SubString(string haystack, string needle)
        {
            int bigIndex = 0;
            int littleIndex = 0;

            while (bigIndex < haystack.Length)
            {
                while (bigIndex + littleIndex < haystack.Length && littleIndex < needle.Length && haystack[bigIndex + littleIndex] == needle[littleIndex])
                {
                    if (littleIndex + 1 == needle.Length)
                        return true;

                    littleIndex++;
                }

                littleIndex = 0;
                bigIndex++;
            }

            return false;
        }

        static void Main10()
        {
            Console.WriteLine("Please enter your Haystack string (< 100 characters): ");
            string haystack = Console.ReadLine();

            Console.WriteLine("Please enter your Needle string (< 100 characters): ");
            string needle = Console.ReadLine();

            if (string.IsNullOrEmpty(haystack) || string.IsNullOrEmpty(needle))
            {
                Console.WriteLine("Please enter valid strings for Haystack and Needle.");
                return;
            }

            if (SubString(haystack, needle))
                Console.WriteLine("Needle was found in Haystack!");
            else
                Console.WriteLine("Needle not found in Haystack");
        }
    }

}
