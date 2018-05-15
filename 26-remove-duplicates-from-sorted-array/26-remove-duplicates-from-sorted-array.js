/**
 * @param {number[]} nums
 * @return {number}
 */
var removeDuplicates = function (nums) {
    if (!nums.length) {
        return 0;
    }

    var index = 0;

    for (var i = 1, l = nums.length; i < l; i++) {
        if (nums[i] !== nums[index]) {
            index++;
            nums[index] = nums[i];
        }
    }

    return index + 1;
};
