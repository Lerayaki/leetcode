// Runtime: 68 ms, faster than 97.55% of C# online submissions for Implement strStr().
// Memory Usage: 22.2 MB, less than 75.96% of C# online submissions for Implement strStr().
public class Solution {
    public int StrStr(string haystack, string needle)
    {
        if (needle.Length == 0)
            return 0;

        for (int i = 0; i <= haystack.Length - needle.Length; i++)
        {
            if (haystack[i] == needle[0])
            {
                if (haystack.Substring(i, needle.Length) == needle)
                    return i;
            }
        }

        return -1;
    }
}