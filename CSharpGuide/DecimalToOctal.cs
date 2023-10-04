using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGuide
{
    internal class DecimalToOctal
    {

        static int ConvertToOctal(long binary)
        {
            int octal = 0, decimalNumber = 0, i = 0;

            // Step 1: Convert binary to decimal
            // Step 2: Convert decimal to octal

            // Converting binary to decimal
            while (binary != 0)
            {
                decimalNumber += (int)(binary % 10) * (int)Math.Pow(2, i);
                ++i;
                binary /= 10;
            }
            i = 1;

            // Converting decimal to octal
            while (decimalNumber != 0)
            {
                octal += (decimalNumber % 8) * i;
                decimalNumber /= 8;
                i *= 10;
            }
            return octal;
        }

        static void Main3()
        {
            long binary;
            Console.Write("Enter a binary number: ");
            if (long.TryParse(Console.ReadLine(), out binary))
            {
                int octal = ConvertToOctal(binary);
                Console.WriteLine($"{binary} in binary = {octal} in octal");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid binary number.");
            }
        }
    }

}
