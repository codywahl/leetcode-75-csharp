using System.Runtime.InteropServices;

namespace LeetCode75.Solutions.ArraysAndStrings;

public class Solution
{
    public static int Compress(char[] chars)
    {
        if (chars.Length == 0)
        {
            return 0;
        }

        char previousChar = chars[0];
        int outputIndex = 0;
        int count = 1;

        for (int i = 1; i < chars.Length; i++)
        {
            char currentChar = chars[i];

            if (currentChar == previousChar)
            {
                count++;
            }
            else
            {
                WriteCharAndCountToArray(chars, ref outputIndex, previousChar, count);
                previousChar = currentChar; // Update to the new character
                count = 1; // Reset count for the new character
            }
        }

        // Handle the last character group
        WriteCharAndCountToArray(chars, ref outputIndex, previousChar, count);
        return outputIndex;
    }

    public static void WriteCharAndCountToArray(char[] chars, ref int outputIndex, char character, int count)
    {
        chars[outputIndex++] = character;

        if (count > 1)
        {
            foreach (char c in count.ToString())
            {
                chars[outputIndex++] = c;
            }
        }
    }
}