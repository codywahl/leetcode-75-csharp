namespace LeetCode75.Solutions.ArraysAndStrings;

// cspell:ignore nums

public class Solution334
{
    public bool IncreasingTriplet(int[] nums)
    {
        if (nums.Length < 3)
        {
            return false;
        }

        int firstValue = int.MaxValue;
        int secondValue = int.MaxValue;

        for (int i = 0; i < nums.Length; i++)
        {
            int currentValue = nums[i];

            if (currentValue <= firstValue)
            {
                firstValue = currentValue; // Update first value
            }
            else if (currentValue <= secondValue)
            {
                secondValue = currentValue; // Update second value
            }
            else
            {
                // Found a third value that is greater than both first and second
                return true;
            }
        }

        return false;
    }
}