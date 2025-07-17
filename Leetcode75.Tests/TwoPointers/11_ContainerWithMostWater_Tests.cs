using Xunit;
using LeetCode75.Solutions.TwoPointers;

namespace LeetCode75.Tests.TwoPointers;

public class ContainerWithMostWaterTests
{
    private readonly Solution11 _solution = new();

    [Theory]
    [InlineData(new[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 }, 49)]
    [InlineData(new[] { 1, 1 }, 1)]
    public void MaxArea_ShouldReturnExpectedResult(int[] height, int expected)
    {
        // Act
        var result = _solution.MaxArea(height);

        // Assert
        Assert.Equal(expected, result);
    }
}