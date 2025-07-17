namespace LeetCode75.Solutions.TwoPointers;

public class Solution11
{
    public int MaxArea(int[] height)
    {
        if (height.Length < 2)
        {
            return 0; // Not enough lines to form a container
        }

        int leftIndex = 0;
        int rightIndex = height.Length - 1;
        int maxArea = 0;

        while (leftIndex < rightIndex)
        {
            int leftHeight = height[leftIndex];
            int rightHeight = height[rightIndex];
            int width = rightIndex - leftIndex;
            int currentMaxHeight = Math.Min(leftHeight, rightHeight);

            // Calculate the area and update maxArea if it's larger
            int currentArea = width * currentMaxHeight;
            maxArea = Math.Max(maxArea, currentArea);

            // Move the pointer pointing to the shorter line inward
            if (leftHeight < rightHeight)
            {
                leftIndex++;
            }
            else
            {
                rightIndex--;
            }
        }

        return maxArea;
    }
}