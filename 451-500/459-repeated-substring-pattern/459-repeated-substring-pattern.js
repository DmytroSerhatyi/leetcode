/**
 * @param {string} s
 * @return {boolean}
 */
var repeatedSubstringPattern = function (s) {
    var str = s + s;
    str = str.substr(1, str.length - 2);

    return str.indexOf(s) > -1;
};
