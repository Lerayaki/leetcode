// Runtime: 124 ms, faster than 5.30% of C# online submissions for Sqrt(x).
// Memory Usage: 14.5 MB, less than 89.65% of C# online submissions for Sqrt(x).
public class Solution {
    public int MySqrt(int x) {
        long y = 1;
        while (y*y <= x){
            y++;
        }
        return (int)y-1;
    }
}