using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGuide
{
    using System;

    class Remainder
    {
        static void Main9()
        {
            if (int.TryParse(Console.ReadLine(), out int t))
            {
                while (t-- > 0)
                {
                    var inputs = Console.ReadLine().Split(' ');
                    if (inputs.Length >= 2 &&
                       int.TryParse(inputs[0], out int A) &&
                       int.TryParse(inputs[1], out int B))
                    {
                        int rem = A % B;
                        Console.WriteLine(rem);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input, please enter two valid numbers separated by space.");
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid input, please enter a valid number.");
            }
        }
    }

}
