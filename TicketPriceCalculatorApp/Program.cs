using System;

namespace TicketPriceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TICKET PRICE CALCULATOR APP");

            int age;
            while (true)
            {
                Console.Write("Enter your age: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out age) && age >= 0)
                    break;
                else
                    Console.WriteLine("Invalid age. Try again.");
            }

            double price = (age <= 12 || age >= 65) ? 7.0 : 10.0;

          Console.WriteLine("Ticket price: GHC" + price);

        }
    }
}

