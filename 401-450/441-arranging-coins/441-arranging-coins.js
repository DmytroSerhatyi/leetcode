/**
 * @param {number} n
 * @return {number}
 */
var arrangeCoins = function (n) {
    var result = 0;

    while (n >= 0) n -= ++result;

    return result - 1;
};
