/**
 * @param {number[]} nums
 * @return {number}
 */
var majorityElement = function (nums) {
    var candidate = null;
    var counter = 0;
    var l = nums.length;

    for (var i = 0; i < l; i++) {
        var num = nums[i];

        if (counter === 0) {
            candidate = num;
        }

        counter += candidate === num ? 1 : -1;
    }

    return candidate;
};
