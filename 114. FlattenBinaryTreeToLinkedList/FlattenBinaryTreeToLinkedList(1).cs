// Runtime: 116 ms, faster than 31.50% of C# online submissions for Flatten Binary Tree to Linked List.
// Memory Usage: 24.9 MB, less than 58.35% of C# online submissions for Flatten Binary Tree to Linked List.
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
    public void Flatten(TreeNode root) {
        if (root == null) 
            return;
        
        List<TreeNode> list = new List<TreeNode>();
        
        InnerFlatten(root, list);
        
        for (int i=0; i<list.Count-1; i++){
            list[i].left = null;
            list[i].right = list[i+1];
        }
    }
    public void InnerFlatten(TreeNode root, List<TreeNode> list){
        if (root == null)
            return;
        
        list.Add(root);
        
        if (root.left != null)
            InnerFlatten(root.left, list);
        if (root.right != null)
            InnerFlatten(root.right, list);
        
    }
}