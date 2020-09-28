// Runtime: 88 ms, faster than 48.67% of JavaScript online submissions for Minimum Depth of Binary Tree.
// Memory Usage: 43.2 MB, less than 5.01% of JavaScript online submissions for Minimum Depth of Binary Tree.
/**
 * Definition for a binary tree node.
 * function TreeNode(val, left, right) {
 *     this.val = (val===undefined ? 0 : val)
 *     this.left = (left===undefined ? null : left)
 *     this.right = (right===undefined ? null : right)
 * }
 */
/**
 * @param {TreeNode} root
 * @return {number}
 */
var minDepth = function(root) {
    if (root == null)
        return 0
    if (root.left == null && root.right == null)
        return 1
    if (root.right == null)
        return minDepth(root.left) + 1
    if (root.left == null)
        return minDepth(root.right) + 1
    
    return Math.min(minDepth(root.left), minDepth(root.right)) + 1
};