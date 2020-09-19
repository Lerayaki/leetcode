public class Solution {
    public bool CanJump(int[] nums)
    {
        return inner_CanJump(nums, 0);
    }
    public bool inner_CanJump(int[] nums, int i)
    {
        if (i == nums.Length - 1)
            return true;
        if (i >= nums.Length)
            return false;

        int next = nums[i]+i;
        bool canJump = false;

        while (next > 0 && !canJump)
        {
            canJump = inner_CanJump(nums, next);
            next--;
        }
        return canJump;
    }
}