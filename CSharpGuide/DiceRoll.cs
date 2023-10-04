using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGuide
{

    class DiceRollExample
    {
        static Random random = new Random(); // It's better to have one Random instance

        static int DiceRoll(int diceSides)
        {
            if (diceSides < 1)
                throw new ArgumentOutOfRangeException(nameof(diceSides), "DiceSides must be greater than 0");

            return random.Next(1, diceSides + 1); // Random.Next(minValue, maxValue); maxValue is exclusive
        }

        static void Main15()
        {
            Console.WriteLine("Enter the number of sides your die has.");

            if (!int.TryParse(Console.ReadLine(), out var diceSides) || diceSides < 1)
            {
                Console.WriteLine("Invalid input, please enter a positive integer.");
                return;
            }

            int dice = DiceRoll(diceSides);
            Console.WriteLine($"You rolled a {dice}");
        }
    }

}
