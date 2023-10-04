using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGuide
{
    using System;
    using System.Collections.Generic;

    class LexSort
    {
        static void Main23()
        {
            Console.WriteLine("Enter the Number of Strings:");
            int n = Int32.Parse(Console.ReadLine());

            // Getting strings input
            string[] str = new string[n];
            Console.WriteLine("Enter the Strings:");
            for (int i = 0; i < n; i++)
            {
                str[i] = Console.ReadLine();
            }

            // Storing strings in the lexicographical order
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (String.Compare(str[j], str[j + 1]) > 0)
                    {
                        // Swapping strings if they are not in the lexicographical order
                        string temp = str[j];
                        str[j] = str[j + 1];
                        str[j + 1] = temp;
                    }
                }
            }

            // Displaying strings in the lexicographical order
            Console.WriteLine("Strings in the Lexicographical Order is:");
            foreach (string s in str)
            {
                Console.WriteLine(s);
            }
        }
    }

}
