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
    var map = {};
    var max = 0;

    function search(tree) {
        if (!tree) return;

        var val = tree.val;

        if (!map[val]) map[val] = 0;

        var count = ++map[val];

        if (count > max) max = count;

        search(tree.left);
        search(tree.right);
    }

    search(root);

    var result = [];

    for (key in map) {
        if (!map.hasOwnProperty(key)) continue;
        if (map[key] === max) result.push(+key);
    }

    return result;
};
