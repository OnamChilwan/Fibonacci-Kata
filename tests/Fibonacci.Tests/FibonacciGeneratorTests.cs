namespace Fibonacci.Tests
{
    using System.Linq;

    using Fibonacci.Client;

    using NUnit.Framework;

    [TestFixture]
    public class FibonacciGeneratorTests
    {
        public void When_Generating_The_Fibonacci_Sequence()
        {
            var numberOfSteps = 8;
            var subject = new FibonacciGenerator();
            var result = subject.Generate(numberOfSteps).ToList();

            Assert.That(result, Has.Count.EqualTo(numberOfSteps));
            Assert.That(result[0], Is.EqualTo(0));
            Assert.That(result[1], Is.EqualTo(1));
            Assert.That(result[2], Is.EqualTo(1));
            Assert.That(result[3], Is.EqualTo(2));
            Assert.That(result[4], Is.EqualTo(3));
            Assert.That(result[5], Is.EqualTo(5));
            Assert.That(result[6], Is.EqualTo(8));
            Assert.That(result[7], Is.EqualTo(13));
            Assert.That(result[8], Is.EqualTo(21));
        }
    }
}