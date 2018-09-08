/**
 * @param {number[]} nums
 * @return {number}
 */
var minMoves = function (nums) {
    var min = nums[0];
    var sum = min;
    var l = nums.length;

    for (var i = 1; i < l; i++) {
        var num = nums[i];
        sum += num;

        if (num < min) min = num;
    }

    return sum - min * l;
};
