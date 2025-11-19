using JetBrains.Annotations;
using leetcode_csharp.invert_binary_tree;
using Xunit;

namespace leetcode_csharp.Tests.invert_binary_tree;

[TestSubject(typeof(Solution))]
public class SolutionTest
{
    private readonly Solution _solution = new();

    [Fact]
    public void Example1()
    {
        var treeRoot = TreeNodeFactory.OfValues(4, 2, 7, 1, 3, 6, 9);
        var expected = TreeNodeFactory.OfValues(4, 7, 2, 9, 6, 3, 1);
        Assert.Equal(expected, _solution.InvertTree(treeRoot));
    }

    [Fact]
    public void Example2()
    {
        var treeRoot = TreeNodeFactory.OfValues(2, 1, 3);
        var expected = TreeNodeFactory.OfValues(2, 3, 1);
        Assert.Equal(expected, _solution.InvertTree(treeRoot));
    }

    [Fact]
    public void Example3()
    {
        var treeRoot = TreeNodeFactory.OfValues();
        Assert.Null(_solution.InvertTree(treeRoot));
    }
}