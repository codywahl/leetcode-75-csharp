using Xunit;
using LeetCode75.Solutions.ArraysAndStrings;

namespace LeetCode75.Tests.ArraysAndStrings;

// cspell:ignore nums

public class IncreasingTripletSequence_Tests
{
    [Fact]
    public void Test1()
    {
        int[] nums = { 1, 2, 3, 4, 5 };
        bool result = new Solution334().IncreasingTriplet(nums);
        Assert.True(result);
    }

    [Fact]
    public void Test2()
    {
        int[] nums = { 5, 4, 3, 2, 1 };
        bool result = new Solution334().IncreasingTriplet(nums);
        Assert.False(result);
    }

    [Fact]
    public void Test3()
    {
        int[] nums = { 2, 1, 5, 0, 4, 6 };
        bool result = new Solution334().IncreasingTriplet(nums);
        Assert.True(result);
    }

    [Fact]
    public void Test4()
    {
        int[] nums = { 20, 100, 10, 12, 5, 13 };
        bool result = new Solution334().IncreasingTriplet(nums);
        Assert.True(result);
    }

    [Fact]
    public void Test5()
    {
        int[] nums = { 3, 2, 1 };
        bool result = new Solution334().IncreasingTriplet(nums);
        Assert.False(result);
    }

    [Fact]
    public void Test6()
    {
        int[] nums = { 3, 2, 1, 2, 1, 3 };
        bool result = new Solution334().IncreasingTriplet(nums);
        Assert.True(result);
    }
}