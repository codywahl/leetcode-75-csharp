using Xunit;
using LeetCode75.Solutions.SlidingWindow;
namespace LeetCode75.Tests.SlidingWindow;

// cspell:ignore nums

public class MaximumAverageSubArrayITests
{
    private readonly Solution643 _solution = new();

    [Fact]
    public void FindMaxAverage_Example1_ReturnsCorrectResult()
    {
        int[] nums = [1, 12, -5, -6, 50, 3];
        int k = 4;
        double expected = 12.75;
        double result = _solution.FindMaxAverage(nums, k);
        Assert.Equal(expected, result, precision: 2);
    }

    [Fact]
    public void FindMaxAverage_Example2_ReturnsCorrectResult()
    {
        int[] nums = [5];
        int k = 1;
        double expected = 5.0;
        double result = _solution.FindMaxAverage(nums, k);
        Assert.Equal(expected, result, precision: 2);
    }
}