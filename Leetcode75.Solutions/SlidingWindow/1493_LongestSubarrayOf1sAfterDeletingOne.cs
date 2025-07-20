namespace LeetCode75.Solutions.SlidingWindow;

// cspell:ignore nums

public class Solution1493
{
    public int LongestSubArray(int[] nums)
    {
        int left = 0, maxLength = 0, lastZeroIndex = -1;

        for (int right = 0; right < nums.Length; right++)
        {
            if (nums[right] == 0)
            {
                if (lastZeroIndex != -1)
                {
                    left = lastZeroIndex + 1;
                }

                lastZeroIndex = right;
            }

            maxLength = Math.Max(maxLength, right - left);
        }

        return maxLength;
    }
}