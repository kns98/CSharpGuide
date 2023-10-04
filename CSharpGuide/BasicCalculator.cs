using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGuide
{
    using System;

    class BasicCalculator
    {
        static void Input()
        {
            Console.WriteLine("Type number to choose the operation");
            Console.WriteLine("1. +");
            Console.WriteLine("2. -");
            Console.WriteLine("3. *");
            Console.WriteLine("4. /");
            Console.WriteLine("5. ^");
            Console.WriteLine("6. square");
            Console.WriteLine("7. log");
            Console.WriteLine("8. floor");
            Console.WriteLine("9. ceil");
            Console.WriteLine("10. Exit");
            Console.Write("InputNum: ");
        }

        static void Main14()
        {
            int inputNum = 0;
            double a = 0;
            double b = 0;
            double result = 0;
            do
            {
                Input();
                inputNum = Convert.ToInt32(Console.ReadLine());

                switch (inputNum)
                {
                    case 1:
                        Console.Write("Enter First Number: ");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter Second Number: ");
                        b = Convert.ToDouble(Console.ReadLine());
                        result = a + b;
                        Console.WriteLine($"{a} + {b} = {result}");
                        break;
                    case 2:
                        Console.Write("Enter First Number: ");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter Second Number: ");
                        b = Convert.ToDouble(Console.ReadLine());
                        result = a - b;
                        Console.WriteLine($"{a} - {b} = {result}");
                        break;
                    case 3:
                        Console.Write("Enter First Number: ");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter Second Number: ");
                        b = Convert.ToDouble(Console.ReadLine());
                        result = a * b;
                        Console.WriteLine($"{a} * {b} = {result}");
                        break;
                    case 4:
                        Console.Write("Enter Dividend: ");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter Divisor: ");
                        b = Convert.ToDouble(Console.ReadLine());
                        if (b == 0)
                            Console.WriteLine("Please check the divisor; it cannot be zero.");
                        else
                        {
                            result = a / b;
                            Console.WriteLine($"{a} / {b} = {result}");
                        }
                        break;
                    case 5:
                        Console.Write("Enter the base: ");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter the exponent: ");
                        b = Convert.ToDouble(Console.ReadLine());
                        result = Math.Pow(a, b);
                        Console.WriteLine($"{a} ^ {b} = {result}");
                        break;
                    case 6:
                        Console.Write("Enter the radicand: ");
                        a = Convert.ToDouble(Console.ReadLine());
                        result = Math.Sqrt(a);
                        Console.WriteLine($"Square root is {result}");
                        break;
                    case 7:
                        Console.Write("Enter the value for log: ");
                        a = Convert.ToDouble(Console.ReadLine());
                        result = Math.Log(a);
                        Console.WriteLine($"The log is {result}");
                        break;
                    case 8:
                        Console.Write("Enter the number: ");
                        a = Convert.ToDouble(Console.ReadLine());
                        result = Math.Floor(a);
                        Console.WriteLine($"The floor value is {result}");
                        break;
                    case 9:
                        Console.Write("Enter the number: ");
                        a = Convert.ToDouble(Console.ReadLine());
                        result = Math.Ceiling(a);
                        Console.WriteLine($"The ceiling value is {result}");
                        break;
                    case 10:
                        Console.WriteLine("Thank you for using the calculator!");
                        break;
                    default:
                        Console.WriteLine("Invalid number, please choose again.");
                        break;
                }

            } while (inputNum != 10);
        }
    }
  
}
