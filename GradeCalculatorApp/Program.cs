using System;

namespace GradeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("GRADE CALCULATOR APP");

            int grade = 0;
            bool isValid = false;

            while (!isValid)
            {
                Console.Write("Enter your numerical grade (0-100): ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out grade))
                {
                    if (grade >= 0 && grade <= 100)
                        isValid = true;
                    else
                        Console.WriteLine(" Numerical grade must be between 0 and 100.");
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }

            if (grade >= 90)
                Console.WriteLine("Grade: A");
            else if (grade >= 80)
                Console.WriteLine("Grade: B");
            else if (grade >= 70)
                Console.WriteLine("Grade: C");
            else if (grade >= 60)
                Console.WriteLine("Grade: D");
            else
                Console.WriteLine("Grade: F");

            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();
        }
    }
}
   