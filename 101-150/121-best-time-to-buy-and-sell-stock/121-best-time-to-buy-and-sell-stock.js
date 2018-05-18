/**
 * @param {number[]} prices
 * @return {number}
 */
var maxProfit = function (prices) {
    if (!prices || prices.length < 2) return 0;

    var max = 0;
    var min = prices[0];

    for (var i = 1, l = prices.length; i < l; i++) {
        var current = prices[i];

        if (min > current) {
            min = current;
        } else {
            var diff = current - min;

            if (diff > max) {
                max = diff;
            }
        }
    }

    return max;
};
