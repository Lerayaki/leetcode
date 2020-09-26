// Runtime: 248 ms, faster than 39.66% of C# online submissions for Merge Sorted Array.
// Memory Usage: 31.1 MB, less than 5.02% of C# online submissions for Merge Sorted Array.
public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int k = m+n-1;
        int i = m-1;
        int j = n-1;
        
        while(k>=0 && i>=0 && j>=0)
        {
            if(nums1[i] > nums2[j])
            {
                nums1[k--] = nums1[i--];
            }
            else{
                nums1[k--] = nums2[j--];
            }
        }
        while(j>=0)
        {
            nums1[k--] = nums2[j--];
        }
    }
}