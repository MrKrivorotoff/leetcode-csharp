using JetBrains.Annotations;
using leetcode_csharp._1_bit_and_2_bit_characters;
using Xunit;

namespace leetcode_csharp.Tests._1_bit_and_2_bit_characters;

[TestSubject(typeof(Solution))]
public class SolutionTest
{
    private readonly Solution _solution = new();

    [Fact]
    public void Example1()
    {
        int[] bits = [1, 0, 0];
        Assert.True(_solution.IsOneBitCharacter(bits));
    }

    [Fact]
    public void Example2()
    {
        int[] bits = [1, 1, 1, 0];
        Assert.False(_solution.IsOneBitCharacter(bits));
    }
}