using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGuide
{
    using System;

    class EMI
    {
        static void Main27()
        {
            Console.WriteLine("Enter principal amount: ");
            if (!float.TryParse(Console.ReadLine(), out float principal))
            {
                Console.WriteLine("Invalid Input for principal amount.");
                return;
            }

            Console.WriteLine("Enter rate of interest: ");
            if (!float.TryParse(Console.ReadLine(), out float rate))
            {
                Console.WriteLine("Invalid Input for rate of interest.");
                return;
            }

            Console.WriteLine("Enter time in years: ");
            if (!float.TryParse(Console.ReadLine(), out float time))
            {
                Console.WriteLine("Invalid Input for time in years.");
                return;
            }

            rate = rate / (12 * 100); /*one month interest*/
            time = time * 12; /*one month period*/

            float emi = (principal * rate * (float)Math.Pow(1 + rate, time)) / ((float)Math.Pow(1 + rate, time) - 1);

            Console.WriteLine($"Monthly EMI is= {emi:F2}");
        }
    }

}
