/**
 * @param {number[]} g
 * @param {number[]} s
 * @return {number}
 */
var findContentChildren = function (g, s) {
    var comparer = function (a, b) {
        return a - b;
    };

    g.sort(comparer);
    s.sort(comparer);

    var i = g.length - 1;
    var j = s.length - 1;
    var result = 0;

    while (i >= 0 && j >= 0) {
        if (s[j] >= g[i]) {
            result++;
            j--;
        }

        i--;
    }

    return result;
};
