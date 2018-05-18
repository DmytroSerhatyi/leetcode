/**
 * Definition for a binary tree node.
 * function TreeNode(val) {
 *     this.val = val;
 *     this.left = this.right = null;
 * }
 */
/**
 * @param {TreeNode} root
 * @param {number} sum
 * @return {boolean}
 */
var hasPathSum = function (root, sum) {
    if (!root) return false;

    var left = root.left,
        right = root.right,
        val = root.val;

    if (val === sum && !left && !right) return true;

    var leftMatches = hasPathSum(left, sum - val),
        rightMatches = hasPathSum(right, sum - val);

    return leftMatches || rightMatches;
};
