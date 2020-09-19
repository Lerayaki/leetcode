// Runtime: 100 ms, faster than 77.46% of C# online submissions for Jump Game.
// Memory Usage: 26.2 MB, less than 39.79% of C# online submissions for Jump Game.
public class Solution {
    public bool CanJump(int[] nums)
    {
        if (nums.Length <= 1)
            return true;
        int j = nums.Length-1;
        for (int i=nums.Length-2; i>=0; i--){
            if (i+nums[i] >= j)
                j = i;
        }
        return j == 0;
    }
}