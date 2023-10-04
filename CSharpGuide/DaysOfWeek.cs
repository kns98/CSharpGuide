using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGuide
{
    using System;

    class Program
    {
        static void Main6()
        {
            Console.WriteLine("Enter the day number");
            if (int.TryParse(Console.ReadLine(), out int day))
            {
                switch (day)
                {
                    case 1:
                        Console.WriteLine("Day is Monday");
                        break;
                    case 2:
                        Console.WriteLine("Day is Tuesday");
                        break;
                    case 3:
                        Console.WriteLine("Day is Wednesday");
                        break;
                    case 4:
                        Console.WriteLine("Day is Thursday");
                        break;
                    case 5:
                        Console.WriteLine("Day is Friday");
                        break;
                    case 6:
                        Console.WriteLine("Day is Saturday");
                        break;
                    case 7:
                        Console.WriteLine("Day is Sunday");
                        break;
                    default:
                        Console.WriteLine("Wrong choice");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input, please enter a valid number.");
            }
        }
    }

}
