using System.Globalization;

namespace LeetCode75.Solutions.TwoPointers;

// cspell:ignore nums

public class Solution1679
{
    public int MaxOperations(int[] nums, int k)
    {
        if (nums == null || nums.Length < 2)
        {
            return 0;
        }

        Array.Sort(nums);
        int leftIndex = 0, rightIndex = nums.Length - 1;
        int count = 0;

        while (leftIndex < rightIndex)
        {
            int leftValue = nums[leftIndex];
            int rightValue = nums[rightIndex];
            int sum = leftValue + rightValue;

            if (sum == k)
            {
                count++;
                leftIndex++;
                rightIndex--;
            }
            else if (sum < k)
            {
                leftIndex++;
            }
            else
            {
                rightIndex--;
            }
        }

        return count;
    }
}