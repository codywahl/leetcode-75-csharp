using Xunit;
using LeetCode75.Solutions.HashMapAndSets;

// cspell:ignore nums

namespace LeetCode75.Tests.HashMapAndSets;

public class TwoSum_Tests
{
    [Fact]
    public void Test1()
    {
        var nums = new[] { 2, 7, 11, 15 };
        var target = 9;
        var expected = new[] { 0, 1 };

        var result = new Solution1().TwoSum(nums, target);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test2()
    {
        var nums = new[] { 3, 2, 4 };
        var target = 6;
        var expected = new[] { 1, 2 };

        var result = new Solution1().TwoSum(nums, target);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test3()
    {
        var nums = new[] { 3, 3 };
        var target = 6;
        var expected = new[] { 0, 1 };

        var result = new Solution1().TwoSum(nums, target);
        Assert.Equal(expected, result);
    }
}