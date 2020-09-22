// Runtime: 324 ms, faster than 30.01% of C# online submissions for Remove Duplicates from Sorted Array.
// Memory Usage: 32.9 MB, less than 98.13% of C# online submissions for Remove Duplicates from Sorted Array.
public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if (nums.Length == 0)
            return 0;
        int i=0;
        for (int j=1; j<nums.Length; j++){
            if (nums[i] != nums[j]){
                i++;
                nums[i] = nums[j];
            }
        }
        return i+1;
    }
}