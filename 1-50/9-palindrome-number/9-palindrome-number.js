/**
 * @param {number} x
 * @return {boolean}
 */
var isPalindrome = function (x) {
    if (x < 0 || x % 10 === 0 && x !== 0) return false;

    var reverted = 0;

    while (x > reverted) {
        var digit = x % 10;
        reverted = reverted * 10 + digit;
        x = (x - digit) / 10;
    }

    return x === reverted || x === parseInt(reverted / 10);
};
