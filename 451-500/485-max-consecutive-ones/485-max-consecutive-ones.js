/**
 * @param {number[]} nums
 * @return {number}
 */
var findMaxConsecutiveOnes = function (nums) {
    var max = 0;
    var current = 0;

    for (var i = 0, l = nums.length; i < l; i++) {
        if (nums[i] === 0) {
            if (current > max) max = current;
            current = 0;
        } else current++;
    }

    return current > max ? current : max;
};
