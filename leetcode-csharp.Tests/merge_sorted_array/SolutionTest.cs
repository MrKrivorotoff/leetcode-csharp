using JetBrains.Annotations;
using leetcode_csharp.merge_sorted_array;
using Xunit;

namespace leetcode_csharp.Tests.merge_sorted_array;

[TestSubject(typeof(Solution))]
public class SolutionTest
{
    private readonly Solution _solution = new();
    
    [Fact]
    public void Example1()
    {
        int[] nums1 = [1, 2, 3, 0, 0, 0];
        int[] nums2 = [2, 5, 6];
        int[] expected = [1, 2, 2, 3, 5, 6];
        _solution.Merge(nums1, 3, nums2, 3);
        Assert.Equal(expected, nums1);
    }
    
    [Fact]
    public void Example2()
    {
        int[] nums1 = [1];
        int[] nums2 = [];
        int[] expected = [1];
        _solution.Merge(nums1, 1, nums2, 0);
        Assert.Equal(expected, nums1);
    }
    
    [Fact]
    public void Example3()
    {
        int[] nums1 = [0];
        int[] nums2 = [1];
        int[] expected = [1];
        _solution.Merge(nums1, 0, nums2, 1);
        Assert.Equal(expected, nums1);
    }
}