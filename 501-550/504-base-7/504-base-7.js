/**
 * @param {number} num
 * @return {string}
 */
var convertToBase7 = function (num) {
    if (num === 0) return '0';

    var minus = false;
    var result = '';

    if (num < 0) {
        minus = true;
        num = -num;
    }

    while (num > 0) {
        var remainder = num % 7;
        result = remainder + result;
        num = (num - remainder) / 7;
    }

    return minus ? '-' + result : result;
};
