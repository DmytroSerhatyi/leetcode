/**
 * @param {number[]} nums
 * @return {number[]}
 */
var findDisappearedNumbers = function (nums) {
    var result = [];
    var l = nums.length;

    for (var i = 0; i < l; i++) {
        var val = Math.abs(nums[i]) - 1;

        if (nums[val] > 0) {
            nums[val] = -nums[val];
        }
    }

    for (i = 0; i < l; i++) {
        if (nums[i] > 0) {
            result.push(i + 1);
        }
    }

    return result;
};
