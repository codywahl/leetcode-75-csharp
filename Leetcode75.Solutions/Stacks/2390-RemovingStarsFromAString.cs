using System.Text;

namespace LeetCode75.Solutions.Stacks;

public static class Solution2390
{
    public static string RemoveStars(string s)
    {
        var result = new StringBuilder();

        foreach (char c in s)
        {
            if (c == '*')
            {
                // Remove the last character from the result if we encounter a star
                if (result.Length > 0)
                {
                    result.Length--; // Remove the last character
                }
            }
            else
            {
                // Append the character to the result if it's not a star
                result.Append(c);
            }
        }

        return result.ToString();
    }
}