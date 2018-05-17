/**
 * Definition for a binary tree node.
 * function TreeNode(val) {
 *     this.val = val;
 *     this.left = this.right = null;
 * }
 */
/**
 * @param {number[]} nums
 * @return {TreeNode}
 */
var sortedArrayToBST = function (nums) {
    if (!nums) return null;

    var min = 0;
    var max = nums.length;

    return createTree(nums, min, max);
};

function createTree(nums, min, max) {
    if (min === max) return null;

    var mid = parseInt((min + max) / 2);

    var tree = new TreeNode(nums[mid]);
    tree.left = createTree(nums, min, mid);
    tree.right = createTree(nums, mid + 1, max);

    return tree;
}
