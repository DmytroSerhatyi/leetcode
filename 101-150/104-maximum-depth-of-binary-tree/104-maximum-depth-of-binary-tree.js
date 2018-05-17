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
var maxDepth = function (root) {
    if (!root) {
        return 0;
    }

    var counterLeft = maxDepth(root.left);
    var counterRight = maxDepth(root.right);

    return (counterLeft > counterRight ? counterLeft : counterRight) + 1;
};
