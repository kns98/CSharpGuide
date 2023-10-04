using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGuide
{
    using System;

    class LoopsEx
    {
        // Mentioning some tools
        // Visual Studio Community and Visual Studio Code are free tools that can be used for writing and debugging C# code.
        // MSDN offers free resources for startups.

        public static readonly string[] cars = new string[] { "BMW", "Volvo", "Saab", "Ford", "Fiat", "Audi" };

        static void Main34(string[] args)
        {
            var text = "";

            // Initialize, Stop, Iterate
            for (int i = 5; i >= 0; i--)
            {
                text += i + " " + cars[i] + "\n"; // Used "\n" instead of "<br>" to create a new line in the console.
            }

            Console.WriteLine(text);

            // HW: Try out a debugger
            // Set a breakpoint and run your code in debug mode to see how variables change at each iteration.
        }
    }

}
