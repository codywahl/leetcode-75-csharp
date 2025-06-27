using Xunit;
using LeetCode75.Solutions.ArraysAndStrings;

namespace LeetCode75.Tests.ArraysAndStrings;

public class ProductOfArrayExceptSelf_Tests
{
    [Fact]
    public void Test1()
    {
        int[] input = { 1, 2, 3, 4 };
        int[] expected = { 24, 12, 8, 6 };
        int[] result = new Solution238().ProductExceptSelf(input);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test2()
    {
        //[-1,1,0,-3,3]
        int[] input = { -1, 1, 0, -3, 3 };
        int[] expected = { 0, 0, 9, 0, 0 };
        int[] result = new Solution238().ProductExceptSelf(input);
        Assert.Equal(expected, result);
    }
}