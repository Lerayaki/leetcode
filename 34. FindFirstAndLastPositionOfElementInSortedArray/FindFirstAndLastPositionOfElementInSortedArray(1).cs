// Runtime: 244 ms, faster than 83.71% of C# online submissions for Find First and Last Position of Element in Sorted Array.
// Memory Usage: 32.3 MB, less than 5.09% of C# online submissions for Find First and Last Position of Element in Sorted Array.
public class Solution {
    public int[] SearchRange(int[] nums, int target)
    {
        int[] output = { -1, -1 };

        if (!nums.Contains(target))
            return output;

        int index = Find(nums, target);
        output[0] = output[1] = index;

        while (output[0] > 0 && nums[output[0]-1] == target)
            output[0]--;

        while (output[1] < nums.Length-1 && nums[output[1]+1] == target)
            output[1]++;
        
        return output;
    }
    public int Find(int[] nums, int target)
    {
        if (nums[nums.Length / 2] == target)
            return nums.Length / 2;
        if (nums[nums.Length / 2] > target)
            return Find(nums.Take(nums.Length / 2).ToArray(), target);
        return nums.Length/2 + Find(nums.Skip(nums.Length / 2).ToArray(), target);
    }
}