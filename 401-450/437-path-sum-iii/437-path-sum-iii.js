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
 * @return {number}
 */
var pathSum = function (root, sum) {
    if (!root) return 0;

    var counter = 0;
    var queue = [root];

    for (var i = 0; i < queue.length; i++) {
        var item = queue[i];

        helper(item, 0, sum);

        if (item.left) queue.push(item.left);
        if (item.right) queue.push(item.right);
    }

    function helper(nodeIn, accumulator, sum) {
        if (!nodeIn) return;

        accumulator += nodeIn.val;

        if (accumulator === sum) counter++;

        helper(nodeIn.left, accumulator, sum);
        helper(nodeIn.right, accumulator, sum);
    }

    return counter;
};
