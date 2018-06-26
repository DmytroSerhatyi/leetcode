/**
 * @param {string} s
 * @return {number}
 */
var longestPalindrome = function (s) {
    var map = {};

    for (var i = 0, l = s.length; i < l; i++) {
        var char = s[i];

        if (map[char]) {
            map[char]++;
        } else {
            map[char] = 1;
        }
    }

    var result = 0;

    for (var key in map) {
        if (!map.hasOwnProperty(key)) continue;

        var num = map[key];

        if (num % 2 === 0) {
            result += num;
        } else {
            result += num - 1;

            if (result % 2 === 0) result += 1;
        }
    }

    return result;
};
