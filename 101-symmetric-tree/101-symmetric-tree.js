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
var isSymmetric = function (root) {
    if (!root) {
        return true;
    }

    return checkSymmetric(root.left, root.right);
};

function checkSymmetric(p, q) {
    var pIsNull = p === null,
        qIsNull = q === null;

    if (pIsNull && qIsNull) {
        return true;
    } else if (pIsNull || qIsNull) {
        return false;
    } else if (p.val === q.val) {
        return checkSymmetric(p.left, q.right) && checkSymmetric(p.right, q.left);
    } else {
        return false;
    }
}
