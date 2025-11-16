using JetBrains.Annotations;
using leetcode_csharp.middle_of_the_linked_list;
using Xunit;

namespace leetcode_csharp.Tests.middle_of_the_linked_list;

[TestSubject(typeof(Solution))]
public class SolutionTest
{
    private readonly Solution _solution = new();

    [Fact]
    public void Example1()
    {
        var head = ListNode.OfValues(1, 2, 3, 4, 5);
        var expected = ListNode.OfValues(3, 4, 5);
        Assert.Equal(expected, _solution.MiddleNode(head));
    }

    [Fact]
    public void Example2()
    {
        var head = ListNode.OfValues(1, 2, 3, 4, 5, 6);
        var expected = ListNode.OfValues(4, 5, 6);
        Assert.Equal(expected, _solution.MiddleNode(head));
    }
}