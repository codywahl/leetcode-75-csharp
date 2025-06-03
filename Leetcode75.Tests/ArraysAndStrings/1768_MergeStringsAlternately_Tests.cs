using Xunit;
using LeetCode75.Solutions.ArraysAndStrings;

// cspell: ignore apbqcr apbqrs apbqcd pqrs pq

namespace LeetCode75.Tests.ArraysAndStrings
{
    public class MergeStringsAlternately_Tests
    {
        [Fact]
        public void Test1()
        {
            var expected = "apbqcr";
            var string1 = "abc";
            var string2 = "pqr";

            var result = Solution1768.MergeAlternately(string1, string2);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test2()
        {
            var expected = "apbqrs";
            var string1 = "ab";
            var string2 = "pqrs";

            var result = Solution1768.MergeAlternately(string1, string2);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test3()
        {
            var expected = "apbqcd";
            var string1 = "abcd";
            var string2 = "pq";

            var result = Solution1768.MergeAlternately(string1, string2);
            Assert.Equal(expected, result);
        }
    }
}
