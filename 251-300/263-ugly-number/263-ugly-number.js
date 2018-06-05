/**
 * @param {number} num
 * @return {boolean}
 */
var isUgly = function (num) {
    if (num < 1) return false;

    var n = 2;
    var i = 1;

    while (n <= 5) {
        while (num % n === 0) num /= n;

        n += i++;
    }

    return num === 1;
};
