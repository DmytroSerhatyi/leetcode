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
var getMinimumDifference = function (root) {
    var min = Infinity;
    var prev = Infinity;

    function traverse(node) {
        if (!node) return;

        traverse(node.left);

        min = Math.min(min, Math.abs(node.val - prev));
        prev = node.val;

        traverse(node.right);
    }

    traverse(root);

    return min;
};
