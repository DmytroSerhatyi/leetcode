/**
 * @param {number} num
 * @return {boolean}
 */
var checkPerfectNumber = function (num) {
    if (num < 2) return false;

    var sum = 1;
    var n = Math.floor(Math.sqrt(num));

    for (var i = 2; i <= n; i++) if (num % i === 0) sum += i + num / i;

    return num === sum;
};
