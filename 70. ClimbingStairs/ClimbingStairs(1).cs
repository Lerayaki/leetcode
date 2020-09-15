// Runtime: 48 ms, faster than 34.04% of C# online submissions for Climbing Stairs.
// Memory Usage: 14.4 MB, less than 97.76% of C# online submissions for Climbing Stairs.
public class Solution {
    public int ClimbStairs(int n)
    {
        int x = 0;
        int y = 1;
        for (int i=0; i<n; i++)
        {
            y = x + y;
            x = y-x;
        }
        return y;
    }
}