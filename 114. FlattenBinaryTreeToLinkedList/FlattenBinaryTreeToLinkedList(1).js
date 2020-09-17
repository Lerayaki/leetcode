// Runtime: 88 ms, faster than 77.52% of JavaScript online submissions for Flatten Binary Tree to Linked List.
// Memory Usage: 38.8 MB, less than 69.32% of JavaScript online submissions for Flatten Binary Tree to Linked List.
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
 * @return {void} Do not return anything, modify root in-place instead.
 */
var flatten = function(root) {
    if (root == null)
        return null
    
    var array = []
    
    var inner_flatten = function(root){
        if (root == null)
            return

        array.push(root)

        if (root.left != null)
            inner_flatten(root.left)
        
        if (root.right != null)
            inner_flatten(root.right)
        
    }
    inner_flatten(root)

    for (var i=0; i<array.length-1; i++){
        array[i].left = null;
        array[i].right = array[i+1];
    }
};