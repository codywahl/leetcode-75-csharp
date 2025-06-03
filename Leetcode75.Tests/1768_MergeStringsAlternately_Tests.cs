using Xunit;
using LeetCode75.Solutions;

// cspell: ignore apbqcr apbqrs apbqcd pqrs pq

namespace LeetCode75.Tests
{
    public class MergeStringsAlternately_Tests
    {
        [Fact]
        public void Test1()
        {
            var expected = "apbqcr";
            var string1 = "abc";
            var string2 = "pqr";
            var solution = new Solution();
            var result = solution.MergeAlternately(string1, string2);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test2()
        {
            var expected = "apbqrs";
            var string1 = "ab";
            var string2 = "pqrs";
            var solution = new Solution();
            var result = solution.MergeAlternately(string1, string2);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test3()
        {
            var expected = "apbqcd";
            var string1 = "abcd";
            var string2 = "pq";
            var solution = new Solution();
            var result = solution.MergeAlternately(string1, string2);
            Assert.Equal(expected, result);
        }
    }
}
