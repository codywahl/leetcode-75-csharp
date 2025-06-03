using System.Text;

namespace LeetCode75.Solutions.ArraysAndStrings
{
    public static class Solution1768
    {
        public static string MergeAlternately(string word1, string word2)
        {
            StringBuilder sb = new();
            int newStringLength = word1.Length + word2.Length;

            for (int i = 0; i < newStringLength; i++)
            {
                if (i < word1.Length)
                {
                    sb.Append(word1[i]);
                }
                if (i < word2.Length)
                {
                    sb.Append(word2[i]);
                }
            }

            return sb.ToString();
        }
    }
}