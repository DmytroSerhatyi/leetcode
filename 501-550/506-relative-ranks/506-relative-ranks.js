/**
 * @param {number[]} nums
 * @return {string[]}
 */
var findRelativeRanks = function (nums) {
    var numsCopy = [];
    var l = nums.length;
    var i;

    function forLoop(func) {
        for (i = 0; i < l; i++) {
            func(i);
        }
    }

    forLoop(function (i) {
        numsCopy.push(nums[i]);
    });

    numsCopy.sort(function (a, b) {
        return b - a;
    });

    var numsMap = {};

    forLoop(function (i) {
        numsMap[numsCopy[i]] = i + 1;
    });

    var result = [];

    forLoop(function (i) {
        var num = numsMap[nums[i]];
        var item;

        switch (num) {
            case 1:
                item = 'Gold Medal';
                break;
            case 2:
                item = 'Silver Medal';
                break;
            case 3:
                item = 'Bronze Medal';
                break;
            default:
                item = num.toString();
                break;
        }

        result.push(item);
    });

    return result;
};
