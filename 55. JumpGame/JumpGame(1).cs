public class Solution {
    public bool CanJump(int[] nums)
    {
        List<int> jumps = new List<int>();
        int index = 0;
        while (true)
        {
            if (index == nums.Length - 1)
                return true;

            if (index == 0 && nums[0] == 0)
                return false;

            if (index > nums.Length-1 || nums[index] == 0)
            {
                index -= jumps.Last();
                jumps.RemoveAt(jumps.Count - 1);
            }
            else
            {
                jumps.Add(nums[index]);
                index += nums[index];
                nums[index - jumps.Last()]--;
            }
        }
    }
}