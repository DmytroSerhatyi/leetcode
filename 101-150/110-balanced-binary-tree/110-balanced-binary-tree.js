/**
 * Definition for a binary tree node.
 * function TreeNode(val) {
 *     this.val = val;
 *     this.left = this.right = null;
 * }
 */
/**
 * @param {TreeNode} root
 * @return {boolean}
 */
var isBalanced = function (root) {
    balaced = true;

    checkBalance(root);

    return balaced;
};

var balaced;

function checkBalance(tree) {
    if (!tree) {
        return 0;
    }

    var left = tree.left ? checkBalance(tree.left) : 0;
    var right = tree.right ? checkBalance(tree.right) : 0;

    if (Math.abs(left - right) > 1) {
        balaced = false;
    }

    return Math.max(left, right) + 1;
}
