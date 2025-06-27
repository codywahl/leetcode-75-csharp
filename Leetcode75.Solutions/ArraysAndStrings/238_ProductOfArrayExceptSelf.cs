namespace LeetCode75.Solutions.ArraysAndStrings;

// cspell:ignore nums

public class Solution238
{
    public int[] ProductExceptSelf(int[] nums)
    {
        if (nums == null || nums.Length < 2 || nums.Length > 100_000)
        {
            throw new ArgumentException("Invalid input: nums must be a non-empty array with length between 2 and 100,000");
        }

        int[] prefixes = new int[nums.Length];
        int[] suffixes = new int[nums.Length];
        int[] result = new int[nums.Length];

        // Calculate prefix products
        prefixes[0] = 1;
        for (int i = 1; i < nums.Length; i++)
        {
            prefixes[i] = prefixes[i - 1] * nums[i - 1];
        }

        // Calculate suffix products
        suffixes[nums.Length - 1] = 1;
        for (int i = nums.Length - 2; i >= 0; i--)
        {
            suffixes[i] = suffixes[i + 1] * nums[i + 1];
        }

        // Calculate result by multiplying prefix and suffix products
        for (int i = 0; i < nums.Length; i++)
        {
            result[i] = prefixes[i] * suffixes[i];
        }

        return result;
    }
}