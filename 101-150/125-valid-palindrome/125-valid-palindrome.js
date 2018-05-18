/**
 * @param {string} s
 * @return {boolean}
 */
var isPalindrome = function (s) {
    s = s.replace(/[^0-9a-zA-Z]/g, '').toLowerCase();

    if (s.length < 2) return true;

    var i = 0;
    var j = s.length - 1;

    while (i < j) {
        var current = s[i],
            opposite = s[j];

        if (current !== opposite) {
            return false;
        }

        i++;
        j--;
    }

    return true;
};
