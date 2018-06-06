/**
 * @param {number[]} nums
 * @return {void} Do not return anything, modify nums in-place instead.
 */
var moveZeroes = function (nums) {
    var step = 1;
    var i = 0;
    var l = nums.length;

    while (i < l - step) {
        var num = nums[i];

        if (num !== 0) {
            i++;
            continue;
        };

        var next = i + step;
        var toSwap = nums[next];

        if (toSwap === 0) {
            step++;
        } else {
            nums[next] = num;
            nums[i] = toSwap;
            i++;
        }
    }
};
