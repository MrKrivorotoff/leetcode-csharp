using JetBrains.Annotations;
using leetcode_csharp.check_if_all_1s_are_at_least_length_k_places_away;
using Xunit;

namespace leetcode_csharp.Tests.check_if_all_1s_are_at_least_length_k_places_away;

[TestSubject(typeof(Solution))]
public class SolutionTest
{
    private readonly Solution _solution = new();
    
    [Fact]
    public void Example1()
    {
        int[] nums = [1, 0, 0, 0, 1, 0, 0, 1];
        Assert.True(_solution.KLengthApart(nums, 2));
    }
    
    [Fact]
    public void Example2()
    {
        int[] nums = [1, 0, 0, 1, 0, 1];
        Assert.False(_solution.KLengthApart(nums, 2));
    }
}