using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGuide
{
    using System;

    class EmpReview
    {
        static void Main8()
        {
            Console.WriteLine("Enter basic salary of employee");

            if (float.TryParse(Console.ReadLine(), out float baseSalary))
            {
                float ta = 0.05f * baseSalary;
                float da = 0.075f * baseSalary;
                float hra = 0.1f * baseSalary;
                float grossSalary = baseSalary + ta + da + hra;

                if (grossSalary >= 100000)
                    Console.WriteLine("A grade employee");
                else if (grossSalary >= 75000)
                    Console.WriteLine("B grade employee");
                else if (grossSalary >= 50000)
                    Console.WriteLine("C grade employee");
                else if (grossSalary >= 20000)
                    Console.WriteLine("D grade employee");
                else
                    Console.WriteLine("E grade employee");
            }
            else
            {
                Console.WriteLine("Invalid input, please enter a valid number.");
            }
        }
    }

}
