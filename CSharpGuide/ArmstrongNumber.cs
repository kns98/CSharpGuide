using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//
// An Armstrong number is an n-digit base b number such that the sum of its (base b) digits raised to the
// power n is the number itself2. For example, 153 is an Armstrong number because 1^3 + 5^3 + 3^3 = 153.
//

namespace CSharpGuide
{

    class ArmstrongNumber
    {
        static void Main13()
        {
            int sum = 0, rem = 0, nthPower = 0, digits = 0, temp;

            // Prompt the user to enter a number
            Console.Write("Enter a number: ");
            // Read the user input, parse it to an integer and assign it to 'number'
            int number = int.Parse(Console.ReadLine());
            temp = number;

            // To calculate the number of digits in the number
            while (number != 0)
            {
                number /= 10;
                digits++;
            }

            number = temp;

            // To get the nth power of each digit and add it to the sum
            while (number != 0)
            {
                rem = number % 10;
                nthPower = (int)Math.Pow(rem, digits);
                sum += nthPower;
                number /= 10;
            }

            // To check if obtained sum is equal to the original number
            if (sum == temp)
                Console.WriteLine("The given number is an Armstrong number");
            else
                Console.WriteLine("The given number is not an Armstrong number");
        }
    }

}
