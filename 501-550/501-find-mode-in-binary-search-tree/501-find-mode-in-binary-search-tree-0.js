/**
 * Definition for a binary tree node.
 * function TreeNode(val) {
 *     this.val = val;
 *     this.left = this.right = null;
 * }
 */
/**
 * @param {TreeNode} root
 * @return {number[]}
 */
var findMode = function (root) {
    var max = 1;
    var count = 1;
    var preVal;
    var mode = [];

    function traverseNode(tree) {
        if (!tree) return;

        traverseNode(tree.left);

        if (tree.val === preVal) count++;
        else count = 1;

        if (count >= max) {
            max = count;

            mode.push({ val: tree.val, count: count });
        }

        preVal = tree.val;

        traverseNode(tree.right);
    }

    traverseNode(root);

    var result = [];

    for (var i = 0, l = mode.length; i < l; i++) {
        var m = mode[i];

        if (m.count === max) result.push(m.val);
    }

    return result;
};
