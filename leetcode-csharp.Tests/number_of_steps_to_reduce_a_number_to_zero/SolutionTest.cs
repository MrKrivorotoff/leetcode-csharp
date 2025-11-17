using JetBrains.Annotations;
using leetcode_csharp.number_of_steps_to_reduce_a_number_to_zero;
using Xunit;

namespace leetcode_csharp.Tests.number_of_steps_to_reduce_a_number_to_zero;

[TestSubject(typeof(Solution))]
public class SolutionTest
{
    private readonly Solution _solution = new();
    
    [Fact]
    public void Example1()
    {
        Assert.Equal(6, _solution.NumberOfSteps(14));
    }
    
    [Fact]
    public void Example2()
    {
        Assert.Equal(4, _solution.NumberOfSteps(8));
    }
    
    [Fact]
    public void Example3()
    {
        Assert.Equal(12, _solution.NumberOfSteps(123));
    }
}