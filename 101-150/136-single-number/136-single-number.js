/**
 * @param {number[]} nums
 * @return {number}
 */
var singleNumber = function (nums) {
    var l = nums.length;

    if (l < 2) return nums[0];

    var result = 0;

    for (var i = 0; i < l; i++) {
        result ^= nums[i];
    }

    return result;
};
