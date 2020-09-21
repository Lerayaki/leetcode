// Runtime: 100 ms, faster than 82.50% of C# online submissions for Longest Common Prefix.
// Memory Usage: 24.2 MB, less than 96.06% of C# online submissions for Longest Common Prefix.
public class Solution {
    public string LongestCommonPrefix(string[] strs)
    {
        if (strs.Length == 0)
            return "";

        string prefix = string.Empty;
        for (int i=0; i<strs[0].Length; i++)
        {
            for (int j = 1; j < strs.Length; j++)
                if (strs[j].Length <= i || strs[j][i] != strs[0][i])
                    return prefix;
            prefix += strs[0][i];
        }
        return prefix;
    }
}