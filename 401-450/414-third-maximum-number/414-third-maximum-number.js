/**
 * @param {number[]} nums
 * @return {number}
 */
var thirdMax = function (nums) {
    var max = -Infinity;
    var preMax = max;
    var prePreMax = max;

    for (var i = 0, l = nums.length; i < l; i++) {
        var num = nums[i];

        if (num === max || num === preMax || num === prePreMax) continue;

        if (num > max) {
            prePreMax = preMax;
            preMax = max;
            max = num;
        } else if (num > preMax) {
            prePreMax = preMax;
            preMax = num;
        } else if (num > prePreMax) {
            prePreMax = num;
        }
    }

    return prePreMax === -Infinity ? max : prePreMax;
};
