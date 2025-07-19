using Xunit;
using LeetCode75.Solutions.SlidingWindow;

namespace LeetCode75.Tests.SlidingWindow;

// cspell:ignore nums

public class Solution1004Tests
{
    private readonly Solution1004 _solution = new Solution1004();

    [Fact]
    public void LongestOnes_Example1_Returns5()
    {
        int[] nums = [1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 0];
        int k = 2;
        int expected = 6;

        int result = _solution.LongestOnes(nums, k);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void LongestOnes_Example2_Returns6()
    {
        int[] nums = [0, 0, 1, 1, 0, 0, 1, 1, 1, 0, 1, 1, 0, 0, 0, 1, 1, 1, 1];
        int k = 3;
        int expected = 10;

        int result = _solution.LongestOnes(nums, k);

        Assert.Equal(expected, result);
    }
}