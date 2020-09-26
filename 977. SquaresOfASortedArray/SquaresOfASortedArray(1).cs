// Runtime: 300 ms, faster than 77.66% of C# online submissions for Squares of a Sorted Array.
// Memory Usage: 40.7 MB, less than 14.83% of C# online submissions for Squares of a Sorted Array.
public class Solution {
    public int[] SortedSquares(int[] A) {
        for(int i=0; i<A.Length; i++){
            A[i] *= A[i];
        }
        Array.Sort(A);
        return A;
    }
}