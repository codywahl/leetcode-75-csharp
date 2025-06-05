using Xunit;
using LeetCode75.Solutions.Stacks;

namespace LeetCode75.Tests.Stacks;

public class RemovingStarsFromAStringTests
{
    [Theory]
    [InlineData("leet**cod*e", "lecoe")]
    [InlineData("erase*****", "")]
    [InlineData("a*b*c*d", "d")]
    [InlineData("abcde", "abcde")]
    [InlineData("*a*b*c*", "")]
    public void RemoveStars_ShouldReturnExpectedResult(string input, string expected)
    {
        // Act
        var result = Solution2390.RemoveStars(input);

        // Assert
        Assert.Equal(expected, result);
    }
}