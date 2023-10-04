using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGuide
{

    class BitwiseAnd
    {
        static void Main5()
        {
            int a = 14, b = 7;
            int c = a & b;
            Console.WriteLine("Value of c = " + c);
        }
    }

    class BitWiseOddEven
    {
        static void RunBitWiseOddEven()
        {
            int mask = 0x1;

            Console.Write("Enter a number: ");
            if (int.TryParse(Console.ReadLine(), out int num))
            {
                num &= mask;

                if (num == 0)
                    Console.WriteLine("Even Number");
                else
                    Console.WriteLine("Odd Number");
            }
            else
            {
                Console.WriteLine("Invalid input, please enter a valid number.");
            }
        }
    }
}



class BitwiseComplement
{
    static void Main17()
    {
        int a = 14;
        int b = ~a;
        Console.WriteLine("Value of b = {0}", b);
    }
}



class BitwiseLeftShift
{
    static void Main18()
    {
        int a = 7;
        int b = 2;
        int c = a << b;
        Console.WriteLine("Value of c = {0}", c);
    }
}
