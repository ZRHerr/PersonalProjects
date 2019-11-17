using System;

public class Solution
{
    public static int Fib(int n)
    {
        // Compute the nth Fibonacci number


        return 0;
    }



    // Tests

    [Fact]
    public void ZerothFibonacciTest()
    {
        var actual = Fib(0);
        var expected = 0;
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void FirstFibonacciTest()
    {
        var actual = Fib(1);
        var expected = 1;
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void SecondFibonacciTest()
    {
        var actual = Fib(2);
        var expected = 1;
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void ThirdFibonacciTest()
    {
        var actual = Fib(3);
        var expected = 2;
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void FifthFibonacciTest()
    {
        var actual = Fib(5);
        var expected = 5;
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TenthFibonacciTest()
    {
        var actual = Fib(10);
        var expected = 55;
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void NegativeFibonacciTest()
    {
        Assert.Throws<ArgumentException>(() => Fib(-1));
    }

    public static void Main(string[] args)
    {
        TestRunner.RunTests(typeof(Solution));
    }
}