namespace LeetCode75.Solutions.ArraysAndStrings;

// cspell:ignore AEIOU 

public class Solution345
{
    public static string ReverseVowels(string s)
    {
        if (string.IsNullOrEmpty(s) || s.Length < 1 || s.Length > 300_000)
        {
            throw new ArgumentException("Invalid input: s must be a non-empty string with length between 1 and 300,000");
        }
        var vowels = "aeiouAEIOU";
        var chars = s.ToCharArray();

        // look for vowels from both ends of the string
        // swap them when found
        // continue until the two pointers meet
        // O(n) time complexity

        int left = 0, right = s.Length - 1;
        while (left < right)
        {
            // move left pointer to the next vowel
            while (left < right && !vowels.Contains(chars[left]))
            {
                left++;
            }

            // move right pointer to the previous vowel
            while (left < right && !vowels.Contains(chars[right]))
            {
                right--;
            }

            // swap the vowels
            if (left < right)
            {
                // Use tuple deconstruction to swap characters
                // This is a more concise way to swap values in C#
                (chars[right], chars[left]) = (chars[left], chars[right]);
                left++;
                right--;
            }
        }

        return new string(chars);
    }
}