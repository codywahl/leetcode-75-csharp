namespace LeetCode75.Solutions.ArraysAndStrings;

public class Solution605
{
    public bool CanPlaceFlowers(int[] flowerbed, int n)
    {
        if (flowerbed == null || flowerbed.Length < 1 || flowerbed.Length > 20_000)
        {
            throw new ArgumentException("Invalid input: flowerbed must be a non-empty array with length between 1 and 20,000");
        }

        if (n < 0 || n > flowerbed.Length)
        {
            throw new ArgumentException("Invalid input: n must be between 0 and the length of the flowerbed.");
        }

        int possibleFlowers = 0;

        for (int i = 0; i < flowerbed.Length; i++)
        {
            bool leftIsEmpty = false;
            bool rightIsEmpty = false;

            if (i == 0)
            {
                leftIsEmpty = true;
            }
            else
            {
                leftIsEmpty = flowerbed[i - 1] == 0;
            }

            if (i == flowerbed.Length - 1)
            {
                rightIsEmpty = true;
            }
            else
            {
                rightIsEmpty = flowerbed[i + 1] == 0;
            }

            if (flowerbed[i] == 0 && leftIsEmpty && rightIsEmpty)
            {
                flowerbed[i] = 1; // Place a flower here
                possibleFlowers++;
            }

            if (possibleFlowers >= n)
            {
                return true; // We can place enough flowers
            }
        }

        return false;
    }
}