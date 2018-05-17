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
var minDepth = function (root) {
    if (!root) return 0;

    var leftIsNull = root.left === null,
        rightIsNull = root.right === null;

    if (leftIsNull && rightIsNull) {
        return 1;
    } else if (!leftIsNull && !rightIsNull) {
        return Math.min(minDepth(root.left), minDepth(root.right)) + 1;
    } else {
        var tree = leftIsNull ? root.right : root.left;
        return minDepth(tree) + 1;
    }

    var left = minDepth(root.left);
    var right = minDepth(root.right);

    return Math.min(left, right) + 1;
};
