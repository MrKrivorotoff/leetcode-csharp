using JetBrains.Annotations;
using leetcode_csharp.keep_multiplying_found_values_by_two;
using Xunit;

namespace leetcode_csharp.Tests.keep_multiplying_found_values_by_two;

[TestSubject(typeof(Solution))]
public class SolutionTest
{
    private readonly Solution _solution = new();

    [Fact]
    public void Example1()
    {
        int[] nums = [5, 3, 6, 1, 12];
        Assert.Equal(24, _solution.FindFinalValue(nums, 3));
    }

    [Fact]
    public void Example2()
    {
        int[] nums = [2, 7, 9];
        Assert.Equal(4, _solution.FindFinalValue(nums, 4));
    }
}