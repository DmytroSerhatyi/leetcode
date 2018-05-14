/**
 * @param {number} x
 * @return {boolean}
 */
var isPalindrome = function (x) {
    var str = x.toString(),
        i = 0,
        k = str.length - 1;

    while (i < k) {
        if (str[i] !== str[k]) {
            return false;
        }
        i++;
        k--;
    }

    return true;
};
