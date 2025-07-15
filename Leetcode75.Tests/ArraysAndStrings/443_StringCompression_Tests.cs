using Xunit;
using LeetCode75.Solutions.ArraysAndStrings;

namespace LeetCode75.Tests.ArraysAndStrings;

public class StringCompressionTests
{
    private readonly Solution _solution = new Solution();

    [Fact]
    public void Compress_Example1_ReturnsCorrectLength()
    {
        char[] chars = { 'a', 'a', 'b', 'b', 'c', 'c', 'c' };
        int expectedLength = 6;

        int result = Solution.Compress(chars);

        Assert.Equal(expectedLength, result);
        var resultSubset = chars.Take(result).ToArray();
        Assert.Equal(['a', '2', 'b', '2', 'c', '3'], resultSubset);
    }

    [Fact]
    public void Compress_Example2_ReturnsCorrectLength()
    {
        char[] chars = { 'a' };
        int expectedLength = 1;

        int result = Solution.Compress(chars);

        Assert.Equal(expectedLength, result);
        Assert.Equal(['a'], chars.Take(result).ToArray());
    }

    [Fact]
    public void Compress_Example3_ReturnsCorrectLength()
    {
        char[] chars = { 'a', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b' };
        int expectedLength = 4;

        int result = Solution.Compress(chars);
        Assert.Equal(expectedLength, result);
        Assert.Equal(['a', 'b', '1', '2'], chars.Take(result).ToArray());
    }
}