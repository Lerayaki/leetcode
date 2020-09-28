// Runtime: 84 ms, faster than 97.95% of C# online submissions for Same Tree.
// Memory Usage: 24.9 MB, less than 5.14% of C# online submissions for Same Tree.
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public bool IsSameTree(TreeNode p, TreeNode q) {
        if (p == null && q == null)
            return true;
        if (p == null)
            return false;
        if (q == null)
            return false;
        if (p.val != q.val)
            return false;
        return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
        
    }
}