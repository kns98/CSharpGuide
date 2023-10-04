using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGuide
{

    class ChangeCase
    {
        static void Main28()
        {
            Console.WriteLine("Enter Uppercase letter :");

            // Reading a single character from the user
            char a = Console.ReadKey().KeyChar;
            Console.WriteLine(); // Move to next line after reading the character

            // Converting the character to lowercase
            char u = char.ToLower(a);

            Console.WriteLine($"Lowercase is : {u}");
        }
    }

}
