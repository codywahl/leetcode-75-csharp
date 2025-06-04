using Xunit;
using LeetCode75.Solutions.ArraysAndStrings;

namespace LeetCode75.Tests.ArraysAndStrings;

public class CanPlaceFlowersTests
{
    private readonly Solution605 _solution = new();

    [Fact]
    public void Test1_CanPlaceFlowers_ValidInput_ReturnsTrue()
    {
        int[] flowerbed = { 1, 0, 0, 0, 1 };
        int n = 1;
        bool result = _solution.CanPlaceFlowers(flowerbed, n);
        Assert.True(result);
    }

    [Fact]
    public void Test2_CanPlaceFlowers_InsufficientSpace_ReturnsFalse()
    {
        int[] flowerbed = { 1, 0, 0, 0, 1 };
        int n = 2;
        bool result = _solution.CanPlaceFlowers(flowerbed, n);
        Assert.False(result);
    }
}