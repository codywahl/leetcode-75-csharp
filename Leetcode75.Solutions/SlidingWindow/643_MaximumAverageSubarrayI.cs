namespace LeetCode75.Solutions.SlidingWindow;

// cspell:ignore nums

public class Solution643
{
    public double FindMaxAverage(int[] nums, int k)
    {
        if (nums == null || nums.Length < k || k <= 0)
        {
            return 0.0; // Invalid input
        }

        double currentSum = 0.0;

        // Calculate the sum of the first 'k' elements
        for (int i = 0; i < k; i++)
        {
            currentSum += nums[i];
        }

        double maxAverage = currentSum / k;

        // Slide the window across the array
        for (int i = k; i < nums.Length; i++)
        {
            double previousSum = currentSum;
            currentSum += nums[i] - nums[i - k]; // Add new element and remove the oldest one

            if (currentSum > previousSum)
            {
                // If the new sum is greater, update maxAverage
                maxAverage = currentSum / k;
            }
        }

        return maxAverage;
    }
}