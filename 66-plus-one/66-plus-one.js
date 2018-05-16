/**
 * @param {number[]} digits
 * @return {number[]}
 */
var plusOne = function (digits) {
    for (var i = digits.length - 1; i >= 0; i--) {
        if (digits[i] === 9) {
            digits[i] = 0;
        } else {
            break;
        }
    }

    if (i >= 0) {
        digits[i] += 1;
    } else {
        digits.unshift(1);
    }

    return digits;
};
