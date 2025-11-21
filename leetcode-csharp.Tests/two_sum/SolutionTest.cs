using JetBrains.Annotations;
using leetcode_csharp.two_sum;
using Xunit;

namespace leetcode_csharp.Tests.two_sum;

[TestSubject(typeof(Solution))]
public class SolutionTest
{
    private readonly Solution _solution = new();

    [Fact]
    public void Example1()
    {
        int[] nums = [2, 7, 11, 15];
        int[] expected = [0, 1]; 
        Assert.Equal(expected, _solution.TwoSum(nums, 9));
    }

    [Fact]
    public void Example2()
    {
        int[] nums = [3, 2, 4];
        int[] expected = [1, 2];
        Assert.Equal(expected, _solution.TwoSum(nums, 6));
    }
    
    [Fact]
    public void Example3()
    {
        int[] nums = [3, 3];
        int[] expected = [0, 1];
        Assert.Equal(expected, _solution.TwoSum(nums, 6));
    }
}