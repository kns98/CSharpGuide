using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGuide
{
    internal class MathEx
    {

        static void Main2()
        {
            int number1, number2, addition, subtraction, multiplication, division, modulo;

            Console.WriteLine("Enter two numbers:");
            number1 = int.Parse(Console.ReadLine());
            number2 = int.Parse(Console.ReadLine());

            addition = number1 + number2;
            subtraction = number1 - number2;
            multiplication = number1 * number2;

            if (number2 != 0)
            {
                division = number1 / number2;
                modulo = number1 % number2;
            }
            else
            {
                Console.WriteLine("Division by zero is not allowed.");
                division = 0;
                modulo = 0;
            }

            Console.WriteLine($"Addition of number 1 and number 2: {addition}");
            Console.WriteLine($"Subtraction of number 1 and number 2: {subtraction}");
            Console.WriteLine($"Multiplication of number 1 and number 2: {multiplication}");
            Console.WriteLine($"Division of number 1 and number 2: {division}");
            Console.WriteLine($"Modulo of number 1 and number 2: {modulo}");

            Console.ReadKey();
        }

    }     
}
