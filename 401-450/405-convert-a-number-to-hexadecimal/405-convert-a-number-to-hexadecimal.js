/**
 * @param {number} num
 * @return {string}
 */
var toHex = function (num) {
    if (num === 0) return '0';

    var letters = 'abcdef';
    var result = '';

    if (num < 0) num = Math.pow(2, 32) + num;

    while (num > 0) {
        var rem = num % 16;

        result = (rem > 9 ? letters[rem - 10] : rem) + result;

        num = (num - rem) / 16;
    }

    return result;
};
