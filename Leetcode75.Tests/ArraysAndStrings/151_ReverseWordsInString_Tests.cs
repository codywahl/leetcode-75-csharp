using Xunit;
using LeetCode75.Solutions.ArraysAndStrings;

namespace LeetCode75.Tests.ArraysAndStrings;

public class ReverseWordsInString_Tests
{
    [Fact]
    public void Test1()
    {
        string input = "the sky is blue";
        string expected = "blue is sky the";
        string result = new Solution151().ReverseWords(input);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test2()
    {
        string input = "  hello world  ";
        string expected = "world hello";
        string result = new Solution151().ReverseWords(input);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test3()
    {
        string input = "a good   example";
        string expected = "example good a";
        string result = new Solution151().ReverseWords(input);
        Assert.Equal(expected, result);
    }
}