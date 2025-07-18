namespace LeetCode75.Solutions.SlidingWindow;

public class Solution1456
{
    public int MaxVowels(string s, int k)
    {
        if (string.IsNullOrEmpty(s) || k <= 0 || k > s.Length)
        {
            return 0; // Edge case: empty string or invalid k
        }

        HashSet<char> vowels = new()
        {
            { 'a'}, { 'e'}, { 'i'}, { 'o'}, { 'u'}
        };

        int leftIndex = 0;
        int rightIndex = k - 1;

        int currentVowels = 0;

        for (int i = leftIndex; i <= rightIndex; i++)
        {
            if (vowels.Contains(s[i]))
            {
                currentVowels++;
            }
        }

        if (currentVowels == k)
        {
            return k; // All characters in the substring are vowels
        }

        int maxVowels = currentVowels;

        while (rightIndex < s.Length - 1)
        {


            // Slide the window
            if (vowels.Contains(s[leftIndex]))
            {
                currentVowels--;
            }
            leftIndex++;

            rightIndex++;
            if (vowels.Contains(s[rightIndex]))
            {
                currentVowels++;
                maxVowels = Math.Max(maxVowels, currentVowels);

                if (maxVowels == k)
                {
                    return k; // All characters in the substring are vowels
                }
            }
        }

        return maxVowels;
    }
}