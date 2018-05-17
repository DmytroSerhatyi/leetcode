/**
 * @param {number[]} nums
 * @param {number} target
 * @return {number[]}
 */
var twoSum = function (nums, target) {
    var map = {};

    for (var i = 0, l = nums.length; i < l; i++) {
        var num = nums[i];
        var complement = target - num;
        var additional = map[complement];

        if (additional != undefined && additional !== i) {
            return [additional, i];
        }

        map[num] = i;
    }
};
