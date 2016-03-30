namespace Fibonacci.Client
{
    using System.Collections.Generic;

    public class FibonacciGenerator
    {
        public IEnumerable<int> Generate(int numberOfSteps)
        {
            var numbers = new List<int>();

            for (var index = 0; index < numberOfSteps; index++)
            {
                if (index > 1)
                {
                    var firstDigit = numbers[index - 2];
                    var secondDigit = numbers[index - 1];
                    var sum = firstDigit + secondDigit;

                    numbers.Add(sum);
                    continue;
                }

                numbers.Add(index);
            }

            return numbers;
        }
    }
}