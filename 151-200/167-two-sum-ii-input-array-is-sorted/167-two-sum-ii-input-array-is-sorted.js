/**
 * @param {number[]} numbers
 * @param {number} target
 * @return {number[]}
 */
var twoSum = function (numbers, target) {
    var map = {};

    for (var i = 0, l = numbers.length; i < l; i++) {
        var num = numbers[i];
        var part = target - num;
        var numInMap = map[part];

        if (numInMap != undefined) {
            return [numInMap + 1, i + 1];
        } else {
            map[num] = i;
        }
    }

    return null;
};
