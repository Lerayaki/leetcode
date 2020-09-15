
// Runtime: 124 ms, faster than 10.19% of JavaScript online submissions for Maximum Depth of Binary Tree.
// Memory Usage: 38.9 MB, less than 86.32% of JavaScript online submissions for Maximum Depth of Binary Tree.
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
    return Math.max(maxDepth(root.left), maxDepth(root.right)) + 1;
};