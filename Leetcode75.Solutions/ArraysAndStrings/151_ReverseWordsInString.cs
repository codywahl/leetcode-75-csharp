namespace LeetCode75.Solutions.ArraysAndStrings;

public class Solution151
{
    public string ReverseWords(string s)
    {
        const char Delimiter = ' ';
        if (string.IsNullOrEmpty(s) || s.Length > 10000 || s.Length < 1)
        {
            throw new ArgumentException("Invalid input: s must be a non-empty string with length between 1 and 10000");
        }

        s = s.Trim();

        if (s.Contains(Delimiter))
        {
            var words = s.Split(Delimiter, StringSplitOptions.RemoveEmptyEntries);
            // use a Collection Extension method to reverse the words
            // this is a more concise way to reverse a collection in C#
            words = [.. words.Reverse()];
            var reversedString = string.Join(Delimiter.ToString(), words);

            return reversedString;
        }

        return s;
    }
}