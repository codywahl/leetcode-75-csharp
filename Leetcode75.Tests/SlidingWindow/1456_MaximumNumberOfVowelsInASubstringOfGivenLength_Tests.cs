using Xunit;
using LeetCode75.Solutions.SlidingWindow;

namespace LeetCode75.Tests.SlidingWindow;

// cspell:ignore abciiidef aeiou leetcode weallloveyou

public class MaximumNumberOfVowelsInASubstringOfGivenLengthTests
{
    private readonly Solution1456 _solution = new();

    [Fact]
    public void MaxVowels_EmptyString_ReturnsZero()
    {
        string s = "";
        int k = 3;
        int expected = 0;
        int result = _solution.MaxVowels(s, k);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void MaxVowels_Example1_ReturnsCorrectResult()
    {
        string s = "abciiidef";
        int k = 3;
        int expected = 3;
        int result = _solution.MaxVowels(s, k);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void MaxVowels_Example2_ReturnsCorrectResult()
    {
        string s = "aeiou";
        int k = 2;
        int expected = 2;
        int result = _solution.MaxVowels(s, k);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void MaxVowels_Example3_ReturnsCorrectResult()
    {
        string s = "leetcode";
        int k = 3;
        int expected = 2;
        int result = _solution.MaxVowels(s, k);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void MaxVowels_Example4_ReturnsCorrectResult()
    {
        string s = "weallloveyou";
        int k = 7;
        int expected = 4;
        int result = _solution.MaxVowels(s, k);
        Assert.Equal(expected, result);
    }
}