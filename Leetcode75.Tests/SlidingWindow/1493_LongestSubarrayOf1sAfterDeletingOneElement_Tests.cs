using Xunit;
using LeetCode75.Solutions.SlidingWindow;

namespace LeetCode75.Tests.SlidingWindow;

// cspell:ignore nums

public class Solution1493Tests
{
    private readonly Solution1493 solution = new();

    [Fact]
    public void LongestSubArray_Example1_Returns5()
    {
        int[] nums = [1, 1, 0, 1];
        int expected = 3;

        int result = solution.LongestSubArray(nums);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void LongestSubArray_Example2_Returns4()
    {
        int[] nums = [0, 1, 1, 1, 0, 1, 1, 0, 1];
        int expected = 5;

        int result = solution.LongestSubArray(nums);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void LongestSubArray_Example3_Returns3()
    {
        int[] nums = [1, 1, 1];
        int expected = 2;

        int result = solution.LongestSubArray(nums);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void LongestSubArray_Example4_Returns0()
    {
        int[] nums = [0, 0, 0];
        int expected = 0;

        int result = solution.LongestSubArray(nums);

        Assert.Equal(expected, result);
    }
}