// Runtime: 252 ms, faster than 54.07% of C# online submissions for Find First and Last Position of Element in Sorted Array.
// Memory Usage: 32 MB, less than 18.66% of C# online submissions for Find First and Last Position of Element in Sorted Array.
public class Solution {
    public int[] SearchRange(int[] nums, int target)
    {
        int[] output = { -1, -1 };

        if (!nums.Contains(target))
            return output;

        int index = Array.IndexOf(nums, target);
        output[0] = output[1] = index;

        while (output[1] < nums.Length-1 && nums[output[1]+1] == target)
            output[1]++;
        
        return output;
    }
}