/**
 * @param {string} s
 * @return {number}
 */
var lengthOfLongestSubstring = function (s) {
    var l = s.length;
    var max = 0;
    var map = {};

    for (var i = 0, j = 0; i < l; i++) {
        var c = s[i];

        if (map[c]) j = Math.max(map[c], j);

        max = Math.max(max, i - j + 1);
        map[c] = i + 1;
    }

    return max;
};
