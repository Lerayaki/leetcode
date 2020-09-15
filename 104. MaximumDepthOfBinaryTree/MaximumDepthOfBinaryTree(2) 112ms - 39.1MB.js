
// Runtime: 112 ms, faster than 16.54% of JavaScript online submissions for Maximum Depth of Binary Tree.
// Memory Usage: 39.1 MB, less than 70.98% of JavaScript online submissions for Maximum Depth of Binary Tree.
function TreeNode(val, left, right) {
    this.val = (val===undefined ? 0 : val)
    this.left = (left===undefined ? null : left)
    this.right = (right===undefined ? null : right)
}

/**
 * @param {TreeNode} root
 * @return {number}
 */
var maxDepth = function(root) {
    if (root == null) 
        return 0;
    if (root.left == null && root.right == null)
        return 1;
    if (root.left == null)
        return maxDepth(root.right) + 1;
    if (root.right == null)
        return maxDepth(root.left) + 1;
    return Math.max(maxDepth(root.left), maxDepth(root.right)) + 1;
};