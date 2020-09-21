// Runtime: 104 ms, faster than 65.57% of C# online submissions for Longest Common Prefix.
// Memory Usage: 24.7 MB, less than 39.57% of C# online submissions for Longest Common Prefix.
public class Solution {
    public string LongestCommonPrefix(string[] strs)
    {
        if (strs.Length == 0)
            return "";

        string prefix = string.Empty;
        Array.Sort(strs, (x, y) => x.Length.CompareTo(y.Length));
        for (int i=0; i<strs[0].Length; i++)
        {
            for (int j = 1; j < strs.Length; j++)
                if (strs[j][i] != strs[0][i])
                    return prefix;
            prefix += strs[0][i];
        }
        return prefix;
    }
}