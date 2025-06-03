using Xunit;
using LeetCode75.Solutions.ArraysAndStrings;

// cspell: ignore ABCABC ABC ABABAB

namespace LeetCode75.Solutions.ArraysAndStrings;

public class GCDOfStrings_Tests
{
    [Fact]
    public void Test1()
    {
        var expected = "ABC";
        var str1 = "ABCABC";
        var str2 = "ABC";

        var result = Solution1071.GcdOfStrings(str1, str2);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test2()
    {
        var expected = "AB";
        var str1 = "ABABAB";
        var str2 = "ABAB";

        var result = Solution1071.GcdOfStrings(str1, str2);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test3()
    {
        var expected = string.Empty;
        var str1 = "LEET";
        var str2 = "CODE";

        var result = Solution1071.GcdOfStrings(str1, str2);
        Assert.Equal(expected, result);
    }
}