using System;

namespace TriangleTypeIdentifier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TRIANGLE TYPE IDENTIFIER APP");

            double side1, side2, side3;

            // Get valid input for side1
            while (true)
            {
                Console.Write("Enter side 1: ");
                string input = Console.ReadLine();
                if (double.TryParse(input, out side1) && side1 > 0)
                    break;
                else
                    Console.WriteLine("Invalid input. Please enter a positive number.");
            }

            // Get valid input for side2
            while (true)
            {
                Console.Write("Enter side 2: ");
                string input = Console.ReadLine();
                if (double.TryParse(input, out side2) && side2 > 0)
                    break;
                else
                    Console.WriteLine("Invalid input. Please enter a positive number.");
            }

            // Get valid input for side3
            while (true)
            {
                Console.Write("Enter side 3: ");
                string input = Console.ReadLine();
                if (double.TryParse(input, out side3) && side3 > 0)
                    break;
                else
                    Console.WriteLine("Invalid input. Please enter a positive number.");
            }

            // Check if the sides form a valid triangle using the triangle inequality rule
            if (side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1)
            {
                if (side1 == side2 && side2 == side3)
                {
                    Console.WriteLine("The triangle is Equilateral.");
                }
                else if (side1 == side2 || side1 == side3 || side2 == side3)
                {
                    Console.WriteLine("The triangle is Isosceles.");
                }
                else
                {
                    Console.WriteLine("The triangle is Scalene.");
                }
            }
            else
            {
                Console.WriteLine("The sides do not form a valid triangle.");
            }
        }
    }
}

