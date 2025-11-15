using JetBrains.Annotations;
using leetcode_csharp.merge_two_sorted_lists;
using Xunit;

namespace leetcode_csharp.Tests.merge_two_sorted_lists;

[TestSubject(typeof(Solution))]
public class SolutionTest
{
    private readonly Solution _solution = new();
    
    [Fact]
    public void Example1()
    {
        var list1 = ListNode.OfValues(1, 2, 4);
        var list2 = ListNode.OfValues(1, 3, 4);
        var expected = ListNode.OfValues(1, 1, 2, 3, 4, 4);
        Assert.Equal(expected, _solution.MergeTwoLists(list1, list2));
    }
    
    [Fact]
    public void Example2()
    {
        var list1 = ListNode.OfValues();
        var list2 = ListNode.OfValues();
        Assert.Null(_solution.MergeTwoLists(list1, list2));
    }
    
    [Fact]
    public void Example3()
    {
        var list1 = ListNode.OfValues();
        var list2 = ListNode.OfValues(0);
        var expected = ListNode.OfValues(0);
        Assert.Equal(expected, _solution.MergeTwoLists(list1, list2));
    }
}