using Xunit;
using LeetCode75.Solutions.ArraysAndStrings;

// cspell:ignore leetcode leotcede AceCreIm

namespace LeetCode75.Tests.ArraysAndStrings;

public class ReverseVowelsOfAString_Tests
{

    [Fact]
    public void Test1()
    {
        string input = "IceCreAm";
        string expected = "AceCreIm";
        string result = Solution345.ReverseVowels(input);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test2()
    {
        string input = "leetcode";
        string expected = "leotcede";
        string result = Solution345.ReverseVowels(input);
        Assert.Equal(expected, result);
    }
}