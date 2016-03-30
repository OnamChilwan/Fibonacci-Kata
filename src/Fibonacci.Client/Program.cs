namespace Fibonacci.Client
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            var fibonacci = new FibonacciGenerator();

            Console.WriteLine("Enter an invalid number to quit.");

            while (true)
            {
                Console.WriteLine("Enter the number of sequences: ");
                int steps;

                if (int.TryParse(Console.ReadLine(), out steps))
                {
                    var numbers = fibonacci.Generate(steps).ToList();

                    Console.WriteLine("-------------------");

                    numbers.ForEach(Console.WriteLine);
                    continue;
                }

                break;
            }
        }
    }
}