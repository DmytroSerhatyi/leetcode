/**
 * @param {string} s
 * @return {string}
 */
var reverseString = function (s) {
    var r = '';

    for (var i = s.length - 1; i >= 0; i--) {
        r += s[i];
    }

    return r;
};
