// Runtime: 248 ms, faster than 39.66% of C# online submissions for Merge Sorted Array.
// Memory Usage: 31.1 MB, less than 5.02% of C# online submissions for Merge Sorted Array.
public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int[] aux = nums1.Take(m).ToArray();

        int i = 0, j = 0;
        while (i < m || j < n)
        {
            if (i<m && (j==n || aux[i] < nums2[j]))
            {
                nums1[i + j] = aux[i];
                i++;
                continue;
            }

            nums1[i + j] = nums2[j];
            j++;
        }
    }
}