using JetBrains.Annotations;
using leetcode_csharp.ransom_note;
using Xunit;

namespace leetcode_csharp.Tests.ransom_note;

[TestSubject(typeof(Solution))]
public class SolutionTest
{
    private readonly Solution _solution = new();
    
    [Fact]
    public void Example1()
    {
        const string ransomNote = "a";
        const string magazine = "b";
        Assert.False(_solution.CanConstruct(ransomNote, magazine));
    }
    
    [Fact]
    public void Example2()
    {
        const string ransomNote = "aa";
        const string magazine = "ab";
        Assert.False(_solution.CanConstruct(ransomNote, magazine));
    }
    
    [Fact]
    public void Example3()
    {
        const string ransomNote = "aa";
        const string magazine = "aab";
        Assert.True(_solution.CanConstruct(ransomNote, magazine));
    }
}