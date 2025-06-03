namespace LeetCode75.Solutions.ArraysAndStrings;

public class Solution1431
{
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
    {
        if (candies.Length < 2 || candies.Length > 100)
        {
            return new List<bool>();
        }

        if (extraCandies < 1 || extraCandies > 50)
        {
            return new List<bool>();
        }

        int maxCandies = candies.Max();
        var result = new List<bool>(candies.Length);

        foreach (var candy in candies)
        {
            // Check if the current kid can have the greatest number of candies
            result.Add(candy + extraCandies >= maxCandies);
        }

        return result;
    }
}