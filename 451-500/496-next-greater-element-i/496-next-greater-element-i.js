/**
 * @param {number[]} findNums
 * @param {number[]} nums
 * @return {number[]}
 */
var nextGreaterElement = function (findNums, nums) {
    var result = [];

    for (var i = 0, l = findNums.length; i < l; i++) {
        var findNum = findNums[i];
        var index = nums.indexOf(findNum);

        if (index !== -1) while (nums[++index] < findNum);

        result.push(index >= nums.length ? -1 : nums[index]);
    }

    return result;
};
