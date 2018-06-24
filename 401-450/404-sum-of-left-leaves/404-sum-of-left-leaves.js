/**
 * Definition for a binary tree node.
 * function TreeNode(val) {
 *     this.val = val;
 *     this.left = this.right = null;
 * }
 */
/**
 * @param {TreeNode} root
 * @return {number}
 */
var sumOfLeftLeaves = function (root) {
    return helper(root, false);
};

function helper(root, isLeft) {
    if (!root) return 0;

    var isLeaf = !root.left && !root.right;

    if (isLeaf && isLeft) return root.val;
    else return helper(root.left, true) + helper(root.right, false);
}
