using System;
using DCIT318Assignment2;

namespace DCIT318Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                Console.Clear();
                Console.WriteLine("=== DCIT 318: Assignment 2 Menu ===");
                Console.WriteLine("1. Inheritance & Method Overriding");
                Console.WriteLine("2. Abstract Classes and Methods");
                Console.WriteLine("3. Interfaces");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option (1–4): ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        RunInheritanceExample();
                        break;

                    case "2":
                        RunAbstractClassExample();
                        break;

                    case "3":
                        // To be implemented
                        break;

                    case "4":
                        running = false;
                        Console.WriteLine("Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Press any key to try again.");
                        Console.ReadKey();
                        break;
                }
            }
        }

        static void RunInheritanceExample()
        {
            Console.Clear();
            Console.WriteLine("Inheritance and Method Overriding Demo:\n");

            Animal baseAnimal = new Animal();
            Animal dog = new Dog();
            Animal cat = new Cat();

            baseAnimal.MakeSound();  // Some generic sound
            dog.MakeSound();         // Bark
            cat.MakeSound();         // Meow

            Console.WriteLine("\nPress any key to return to the main menu...");
            Console.ReadKey();
        }


        static void RunAbstractClassExample()
        {
            Console.Clear();
            Console.WriteLine("Abstract Classes and Methods Demo:\n");

            // Circle input
            Console.Write("Enter radius of the circle: ");
            double radius = double.Parse(Console.ReadLine());

            // Rectangle input
            Console.Write("Enter width of the rectangle: ");
            double width = double.Parse(Console.ReadLine());

            Console.Write("Enter height of the rectangle: ");
            double height = double.Parse(Console.ReadLine());

            // Create objects
            Shape circle = new Circle(radius);
            Shape rectangle = new Rectangle(width, height);

            // Display areas
            Console.WriteLine($"\nCircle Area: {circle.GetArea():0.00}");
            Console.WriteLine($"Rectangle Area: {rectangle.GetArea():0.00}");

            Console.WriteLine("\nPress any key to return to the main menu...");
            Console.ReadKey();
        }

    }
}
