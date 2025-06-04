namespace LeetCode75.Solutions.TwoPointers;

// cspell:ignore nums

public class Solution283
{
    public void MoveZeroes(int[] nums)
    {
        int lastNonZeroIndex = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                nums[lastNonZeroIndex] = nums[i];
                lastNonZeroIndex++;
            }
        }

        for (int i = lastNonZeroIndex; i < nums.Length; i++)
        {
            nums[i] = 0;
        }
    }
}