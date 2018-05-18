/**
 * @param {number} n
 * @return {string}
 */
var convertToTitle = function (n) {
    if (n <= 0) return '';

    n -= 1;
    return convertToTitle(parseInt(n / 26)) + String.fromCharCode('A'.charCodeAt(0) + (n % 26));
};
