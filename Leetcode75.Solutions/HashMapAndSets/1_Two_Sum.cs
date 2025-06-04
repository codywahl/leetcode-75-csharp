namespace LeetCode75.Solutions.HashMapAndSets;

//cspell:ignore nums

public class Solution1
{
    public int[] TwoSum(int[] nums, int target)
    {
        int numsLength = nums.Length;

        if (numsLength < 2 || numsLength > 10_000)
        {
            throw new ArgumentException("Invalid input: nums must have at least 2 and at most 10,000 elements");
        }

        if (target < -1_000_000_000 || target > 1_000_000_000)
        {
            throw new ArgumentException("Invalid input: target must be between -1,000,000,000 and 1,000,000,000");
        }

        var previousNumbers = new Dictionary<int, int>();

        for (int i = 0; i < numsLength; i++)
        {
            int currentNumber = nums[i];

            if (currentNumber < -1_000_000_000 || currentNumber > 1_000_000_000)
            {
                throw new ArgumentException("Invalid input: each number in nums must be between -1,000,000,000 and 1,000,000,000");
            }

            if (i == 0)
            {
                previousNumbers.Add(i, currentNumber);
                continue;
            }

            int difference = target - currentNumber;

            if (previousNumbers.ContainsValue(difference))
            {
                int previousIndex = previousNumbers.FirstOrDefault(x => x.Value == difference).Key;
                return [previousIndex, i];
            }

            previousNumbers.Add(i, currentNumber);

        }

        return Array.Empty<int>(); // Return an empty array if no solution is found
    }
}