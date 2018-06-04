/**
 * Definition for a binary tree node.
 * function TreeNode(val) {
 *     this.val = val;
 *     this.left = this.right = null;
 * }
 */
/**
 * @param {TreeNode} root
 * @return {string[]}
 */
var binaryTreePaths = function (root) {
    var result = [];

    createPaths(root, '', result);

    return result;
};

function createPaths(root, str, store) {
    if (root === null) {
        return;
    }

    str += root.val;

    if (root.left === null && root.right === null) {
        store.push(str);
    } else {
        str += '->';
        createPaths(root.left, str, store);
        createPaths(root.right, str, store);
    }
}
