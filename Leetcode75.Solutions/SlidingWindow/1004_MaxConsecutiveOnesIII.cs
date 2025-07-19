namespace LeetCode75.Solutions.SlidingWindow;

// cspell:ignore nums

public class Solution1004
{
    public int LongestOnes(int[] nums, int k)
    {
        int left = 0, right = 0, maxLength = 0, zeroCount = 0;

        while (right < nums.Length)
        {
            // advance the right pointer
            if (nums[right] == 0)
            {
                zeroCount++;
            }

            // advance the left pointer if we have more than k zeros in the window
            while (zeroCount > k)
            {
                if (nums[left] == 0)
                {
                    zeroCount--;
                }

                left++;
            }

            maxLength = Math.Max(maxLength, right - left + 1);
            right++;
        }

        return maxLength;
    }
}