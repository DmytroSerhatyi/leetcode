/**
 * @param {string} s
 * @return {number}
 */
var lengthOfLongestSubstring = function (s) {
    var map = {};
    var max = 0;
    var counter = 0;

    for (var i = 0, l = s.length; i < l; i++) {
        var c = s[i];

        if (map[c] == null) {
            counter++;
            map[c] = i;
        } else {
            if (counter > max) max = counter;

            counter = 0;
            i = map[c];
            map = {};
        }
    }

    return counter > max ? counter : max;
};
