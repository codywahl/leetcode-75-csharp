using Xunit;
using LeetCode75.Solutions.TwoPointers;

namespace LeetCode75.Tests.TwoPointers;

// cspell:ignore nums

public class MaxNumberOfKSumPairs_Tests
{
    private readonly Solution1679 _solution = new();

    [Fact]
    public void MaxOperations_Example1_Returns3()
    {
        int[] nums = { 1, 2, 3, 4 };
        int k = 5;
        int expected = 2;
        Assert.Equal(expected, _solution.MaxOperations(nums, k));
    }

    [Fact]
    public void MaxOperations_Example2_Returns2()
    {
        int[] nums = { 3, 1, 3, 4, 3 };
        int k = 6;
        int expected = 1;
        Assert.Equal(expected, _solution.MaxOperations(nums, k));
    }
}