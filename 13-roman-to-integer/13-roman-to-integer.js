/**
 * @param {string} s
 * @return {number}
 */
var romanToInt = function (s) {
    var map = {
        I: 1,
        V: 5,
        X: 10,
        L: 50,
        C: 100,
        D: 500,
        M: 1000
    };

    var result = 0;

    for (var i = 0; i < s.length; i++) {
        var num = map[s[i]];
        result += num < map[s[i + 1]] ? -num : num;
    }

    return result;
};
