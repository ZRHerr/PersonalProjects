using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;

namespace SolutionTests
{
    [TestClass]
    public class FibTests
    {
        public void RunTests(Program program)
        {
            ZerothFibonacciTest();
            FirstFibonacciTest();
            SecondFibonacciTest();
            ThirdFibonacciTest();
            FifthFibonacciTest();
            TenthFibonacciTest();
            NegativeFibonacciTest();
        }
        // Tests
        [Fact]
        public void ZerothFibonacciTest()
        {
            var actual = Fib(0);
            var expected = 0;
            Assert.Equals(expected, actual);
        }

        [Fact]
        public void FirstFibonacciTest()
        {
            var actual = Fib(1);
            var expected = 1;
            Assert.Equals(expected, actual);
        }

        [Fact]
        public void SecondFibonacciTest()
        {
            var actual = Fib(2);
            var expected = 1;
            Assert.Equals(expected, actual);
        }

        [Fact]
        public void ThirdFibonacciTest()
        {
            var actual = Fib(3);
            var expected = 2;
            Assert.Equals(expected, actual);
        }

        [Fact]
        public void FifthFibonacciTest()
        {
            var actual = Fib(5);
            var expected = 5;
            Assert.Equals(expected, actual);
        }

        [Fact]
        public void TenthFibonacciTest()
        {
            var actual = Fib(10);
            var expected = 55;
            Assert.Equals(expected, actual);
        }

        [Fact]
        public void NegativeFibonacciTest()
        {
            Assert.ThrowsException<ArgumentException>(() => Fib(-1));
        }

    }
}
