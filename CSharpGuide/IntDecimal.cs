using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGuide
{
    using System;

    class IntDecimal
    {
        static void Main25()
        {
            Console.Write("Enter the Number : ");
            string input = Console.ReadLine();

            if (float.TryParse(input, out float a))
            {
                int b = (int)a; // Integer part of a.
                float c = a - b; // Decimal part of a.

                Console.WriteLine($"Integer Part is : {b}");
                Console.WriteLine($"Decimal Part is : {c:F6}"); // F6 is used to format the floating point to 6 decimal places, you can adjust it as needed.
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
            }
        }
    }

}
