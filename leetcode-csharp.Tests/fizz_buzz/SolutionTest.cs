using JetBrains.Annotations;
using leetcode_csharp.fizz_buzz;
using Xunit;

namespace leetcode_csharp.Tests.fizz_buzz;

[TestSubject(typeof(Solution))]
public class SolutionTest
{
    private readonly Solution _solution = new();

    [Fact]
    public void Example1()
    {
        string[] expected = ["1", "2", "Fizz"];
        Assert.Equal(expected, _solution.FizzBuzz(3));
    }

    [Fact]
    public void Example2()
    {
        string[] expected = ["1", "2", "Fizz", "4", "Buzz"];
        Assert.Equal(expected, _solution.FizzBuzz(5));
    }

    [Fact]
    public void Example3()
    {
        string[] expected =
            ["1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz"];
        Assert.Equal(expected, _solution.FizzBuzz(15));
    }
}