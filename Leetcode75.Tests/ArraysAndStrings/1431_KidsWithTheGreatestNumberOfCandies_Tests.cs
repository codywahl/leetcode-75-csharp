using Xunit;
using LeetCode75.Solutions.ArraysAndStrings;

namespace LeetCode75.Tests.ArraysAndStrings;


public class KidsWithTheGreatestNumberOfCandies_Tests
{
    private readonly Solution1431 _solution = new();

    [Fact]
    public void Test1()
    {
        int[] candies = { 2, 3, 5, 1, 3 };
        int extraCandies = 3;

        var result = _solution.KidsWithCandies(candies, extraCandies);
        Assert.Equal(new List<bool> { true, true, true, false, true }, result);
    }

    [Fact]
    public void Test2()
    {
        int[] candies = { 4, 2, 1, 1, 2 };
        int extraCandies = 1;

        var result = _solution.KidsWithCandies(candies, extraCandies);
        Assert.Equal(new List<bool> { true, false, false, false, false }, result);
    }

    [Fact]
    public void Test3()
    {
        int[] candies = { 12, 1, 12 };
        int extraCandies = 10;

        var result = _solution.KidsWithCandies(candies, extraCandies);
        Assert.Equal(new List<bool> { true, false, true }, result);
    }
}