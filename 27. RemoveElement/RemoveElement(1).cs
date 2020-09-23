// Runtime: 236 ms, faster than 85.76% of C# online submissions for Remove Element.
// Memory Usage: 29.7 MB, less than 95.68% of C# online submissions for Remove Element.
public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int i = 0;
        int j = nums.Length-1;
        
        while (i<=j){
            if (nums[i] == val){
                nums[i] = nums[j];
                j--;
            }
            else
                i++;
        }
        
        return i;
    }
}