using Xunit;
using LeetCode75.Solutions.SlidingWindow;

namespace LeetCode75.Tests.SlidingWindow;

public class BestTimeToBuyAndSellStockTests
{
    private readonly Solution121 solution121 = new();

    [Fact]
    public void Test1()
    {
        var prices = new int[] { 7, 1, 5, 3, 6, 4 };
        var expected = 5;

        var result = solution121.MaxProfit(prices);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test2()
    {
        var prices = new int[] { 7, 6, 4, 3, 1 };
        var expected = 0;

        var result = solution121.MaxProfit(prices);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void MaxProfit_EmptyArray()
    {
        var prices = new int[] { };
        var expected = 0;

        var result = solution121.MaxProfit(prices);

        Assert.Equal(expected, result);
    }
}