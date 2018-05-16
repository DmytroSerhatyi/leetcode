/**
 * @param {number[]} nums
 * @return {number}
 */
var maxSubArray = function (nums) {
    var maxOverall = nums[0];
    var maxCurrent = maxOverall;

    for (var i = 1, l = nums.length; i < l; i++) {
        var num = nums[i];
        maxCurrent = Math.max(num, maxCurrent + num);
        maxOverall = Math.max(maxOverall, maxCurrent);
    }

    return maxOverall;
};
