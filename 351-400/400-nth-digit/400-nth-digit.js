/**
 * @param {number} n
 * @return {number}
 */
var findNthDigit = function (n) {
    var l = 1;
    var count = 9;
    var start = 1;

    while (n > l * count) {
        n -= l * count;
        l++;
        count *= 10;
        start *= 10;
    }

    start += parseInt((n - 1) / l);
    var str = start.toString();
    return +str.charAt((n - 1) % l);
};
