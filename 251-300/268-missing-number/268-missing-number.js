/**
 * @param {number[]} nums
 * @return {number}
 */
var missingNumber = function (nums) {
    var sum = 0;
    var l = nums.length;

    for (var i = 0; i < l; i++) {
        sum += nums[i];
    }

    return l * (l + 1) / 2 - sum;
};
