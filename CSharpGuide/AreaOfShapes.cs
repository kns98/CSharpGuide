using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGuide
{
    using System;

    class Area
    {
        static void Triangle()
        {
            // Prompt the user to enter the base of the triangle
            Console.Write("Enter the base: ");
            // Read the user input, convert it to a float, and assign it to variable 'b'
            float b = float.Parse(Console.ReadLine());

            // Prompt the user to enter the height of the triangle
            Console.Write("Enter the height: ");
            // Read the user input, convert it to a float, and assign it to variable 'h'
            float h = float.Parse(Console.ReadLine());

            // Calculate the area of the triangle using the formula (1/2)*base*height
            float a = 0.5f * b * h;

            // Display the calculated area to the user
            Console.WriteLine("Area is " + a);
        }
    
        static void Square()
        {
            // Prompt the user to enter the side of the square
            Console.Write("Enter the Side: ");
            // Read the user input, convert it to a float, and assign it to variable 's'
            float s = float.Parse(Console.ReadLine());

            // Calculate the area of the square using the formula side*side
            float a = s * s;

            // Display the calculated area to the user
            Console.WriteLine("Area is " + a);
        }

        static void Circle()
        {
            // Prompt the user to enter the radius of the circle
            Console.Write("Enter the Radius: ");
            // Read the user input, convert it to a float, and assign it to variable 'r'
            float r = float.Parse(Console.ReadLine());

            // Calculate the area of the circle using the formula π*radius*radius
            float a = (float)(Math.PI * r * r); // used Math.PI for more precise value of π

            // Display the calculated area to the user
            Console.WriteLine("Area is " + a);
        }
    }

}
