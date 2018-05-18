/**
 * @param {number[]} prices
 * @return {number}
 */
var maxProfit = function (prices) {
    var max = 0,
        l = prices.length;

    for (var i = 1; i < l; i++) {
        var current = prices[i],
            prev = prices[i - 1];

        if (current > prev) {
            max += current - prev;
        }
    }

    return max;
};
