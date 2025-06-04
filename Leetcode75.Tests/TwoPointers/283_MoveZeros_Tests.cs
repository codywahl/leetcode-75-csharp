using Xunit;
using LeetCode75.Solutions.TwoPointers;

//cspell:ignore nums

namespace LeetCode75.Tests.TwoPointers;

public class MoveZerosTests
{
    private readonly Solution283 solution283 = new();

    [Fact]
    public void Test1()
    {
        var nums = new int[] { 0, 1, 0, 3, 12 };
        var expected = new int[] { 1, 3, 12, 0, 0 };

        solution283.MoveZeroes(nums);

        Assert.Equal(expected, nums);
    }

    [Fact]
    public void Test2()
    {
        var nums = new int[] { 0 };
        var expected = new int[] { 0 };

        solution283.MoveZeroes(nums);

        Assert.Equal(expected, nums);
    }
}