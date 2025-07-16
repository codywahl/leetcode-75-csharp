namespace LeetCode75.Solutions.TwoPointers;

public class Solution
{
    public bool IsSubsequence(string s, string t)
    {
        if (s.Length == 0) return true;
        if (t.Length == 0) return false;

        int sIndex = 0, tIndex = 0;

        while (sIndex < s.Length && tIndex < t.Length)
        {
            char currentSChar = s[sIndex];
            char currentTChar = t[tIndex];

            if (currentSChar == currentTChar)
            {
                // Move to the next character in s
                sIndex++;
            }
            // Always move to the next character in t
            tIndex++;
        }

        return sIndex == s.Length;
    }
}