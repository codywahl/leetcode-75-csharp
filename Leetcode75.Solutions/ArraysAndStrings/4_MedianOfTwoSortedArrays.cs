namespace LeetCode75.Solutions.ArraysAndStrings;

public class Solution4
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        if (nums1.Length > nums2.Length)
        {
            (nums1, nums2) = (nums2, nums1); // Ensure nums1 is the smaller array
        }

        int x = nums1.Length;
        int y = nums2.Length;
        int low = 0, high = x;

        while (low <= high)
        {
            int partitionX = (low + high) / 2;
            int partitionY = (x + y + 1) / 2 - partitionX;

            int maxX = (partitionX == 0) ? int.MinValue : nums1[partitionX - 1];
            int minX = (partitionX == x) ? int.MaxValue : nums1[partitionX];

            int maxY = (partitionY == 0) ? int.MinValue : nums2[partitionY - 1];
            int minY = (partitionY == y) ? int.MaxValue : nums2[partitionY];

            if (maxX <= minY && maxY <= minX)
            {
                // Found the correct partitions
                if ((x + y) % 2 == 0)
                {
                    return (Math.Max(maxX, maxY) + Math.Min(minX, minY)) / 2.0;
                }
                else
                {
                    return Math.Max(maxX, maxY);
                }
            }
            else if (maxX > minY)
            {
                high = partitionX - 1; // Move towards the left in nums1
            }
            else
            {
                low = partitionX + 1; // Move towards the right in nums1
            }
        }

        throw new ArgumentException("Input arrays are not sorted or valid.");
    }
}