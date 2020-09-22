// Runtime: 392 ms, faster than 18.82% of C# online submissions for Remove Duplicates from Sorted Array.
// Memory Usage: 33.3 MB, less than 40.39% of C# online submissions for Remove Duplicates from Sorted Array.
public class Solution {
    public int RemoveDuplicates(int[] nums) {
        HashSet<int> hash = new HashSet<int>(nums);
        int i=0;
        foreach(int n in hash){
            nums[i] = n;
            i++;
        }
        return hash.Count;
    }
}