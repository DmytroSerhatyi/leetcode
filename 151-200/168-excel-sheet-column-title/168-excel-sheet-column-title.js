/**
 * @param {number} n
 * @return {string}
 */
var convertToTitle = function (n) {
    var map = 'ABCDEFGHIJKLMNOPQRSTUVWXYZ';
    var l = map.length;
    var title = '';

    while (n >= 1) {
        var remainder = n % l;
        var isZero = remainder === 0;
        var diff = isZero ? l : remainder;

        title = map[diff - 1] + title;
        n -= isZero ? l : remainder;
        n /= l;
    }

    return title;;
};
