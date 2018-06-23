/**
 * @param {number} num
 * @return {string[]}
 */
var readBinaryWatch = function (num) {
    if (!num) return ['0:00'];

    var bitsCombinations = [];

    helper(0, num - 1, 0, 0, bitsCombinations);

    var minutes = parseInt('111111', 2);
    var hours = parseInt('1111', 2);
    var result = [];

    for (var i = 0, l = bitsCombinations.length; i < l; i++) {
        var combination = bitsCombinations[i];
        var curMinute = combination & minutes;

        if (curMinute > 59) continue;

        if (curMinute < 10) curMinute = '0' + curMinute;

        combination >>>= 6;
        var curHour = (combination & hours);

        if (curHour > 11) continue;

        result.push(curHour + ':' + curMinute);
    }

    return result;
};

function helper(level, maxLevel, iteration, prevBits, collection) {
    var maxBitsOnWatch = 10;

    for (var i = iteration; i < maxBitsOnWatch; i++) {
        var bit = 1 << i;
        var allBits = prevBits | bit;

        if (level === maxLevel) {
            collection.push(allBits);
        } else {
            helper(level + 1, maxLevel, i + 1, allBits, collection);
        }
    }
}
