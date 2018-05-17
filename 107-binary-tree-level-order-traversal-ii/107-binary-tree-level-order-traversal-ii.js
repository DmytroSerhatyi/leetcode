/**
 * Definition for a binary tree node.
 * function TreeNode(val) {
 *     this.val = val;
 *     this.left = this.right = null;
 * }
 */
/**
 * @param {TreeNode} root
 * @return {number[][]}
 */
var levelOrderBottom = function (root) {
    var map = [];

    orderNodes(root, map, 0);

    var result = [];

    for (var i = map.length - 1; i >= 0; i--) {
        result.push(map[i]);
    }

    return result;
};

function orderNodes(tree, map, level) {
    if (!tree) return;

    var mapArr = map[level];

    if (mapArr) {
        mapArr.push(tree.val);
    } else {
        map[level] = [tree.val];
    }

    level++;

    orderNodes(tree.left, map, level);
    orderNodes(tree.right, map, level);
}
