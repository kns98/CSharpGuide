using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGuide
{
    using System;
    using System.Collections.Generic;

    namespace ConsoleApp
    {
        // Define a simple Book class with properties for title and author.
        class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }

            public Book(string title, string author)
            {
                Title = title;
                Author = author;
            }

            // Override ToString() to display book information nicely
            public override string ToString()
            {
                return $"{Title} by {Author}";
            }
        }

        class Program
        {
            static void Main33(string[] args)
            {
                // Create a List to store books
                List<Book> bookList = new List<Book>
            {
                new Book("To Kill a Mockingbird", "Harper Lee"),
                new Book("1984", "George Orwell"),
                new Book("Moby Dick", "Herman Melville")
            };

                // Display the list of books
                Console.WriteLine("Books I've read:");
                foreach (var book in bookList)
                {
                    Console.WriteLine(book);
                }
            }


            class Car
            {
                public string Name { get; set; }
                public int Year { get; set; }

                public Car(string name, int year)
                {
                    Name = name;
                    Year = year;
                }
            }

            static void Main35()
            {
                // Creating Car objects and initializing them
                Car myCar1 = new Car("Ford", 2014);
                Car myCar2 = new Car("Audi", 2019);

                // Printing out the car names
                Console.WriteLine($"The first car type is {myCar1.Name}");
                Console.WriteLine($"The second car type is {myCar2.Name}");

                // Constants example
                var carA = new { Type = "Fiat", Model = "500", Color = "White" };
                var carB = new { Type = "Toyota", Model = "1200", Color = "Silver" };

                // Printing out the constant car types
                Console.WriteLine($"The first constant car type is {carA.Type}");
                Console.WriteLine($"The second constant car type is {carB.Type}");
            }
        }

    }

}
