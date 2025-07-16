using Xunit;
using LeetCode75.Solutions.TwoPointers;

namespace LeetCode75.Tests.TwoPointers;

// cspell:ignore s t ahbgdc axc

public class IsSubsequenceTests
{
    private readonly Solution _solution = new();

    [Theory]
    [InlineData("abc", "ahbgdc", true)]
    [InlineData("axc", "ahbgdc", false)]
    public void IsSubsequence_ShouldReturnExpectedResult(string s, string t, bool expected)
    {
        // Act
        var result = _solution.IsSubsequence(s, t);

        // Assert
        Assert.Equal(expected, result);
    }
}