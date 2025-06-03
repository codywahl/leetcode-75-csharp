namespace LeetCode75.Solutions.ArraysAndStrings;

public class Solution1071
{
    public static string GcdOfStrings(string str1, string str2)
    {
        if (str1.Length < 1)
        {
            return string.Empty;
        }

        if (str2.Length > 2000 || str2.Length < 1)
        {
            return string.Empty;
        }

        if (str1 + str2 != str2 + str1)
        {
            return string.Empty;
        }

        int gcdLength = GCD(str1.Length, str2.Length);
        return str1.Substring(0, gcdLength);

    }

    // Use the Euclidean algorithm to find the GCD of two numbers
    // This is a common algorithm for finding the GCD of two integers
    public static int GCD(int n1, int n2)
    {
        while (n1 != 0 && n2 != 0)
        {
            if (n1 > n2)
            {
                n1 %= n2;
            }
            else
            {
                n2 %= n1;
            }
        }

        return n1 | n2;
    }
}