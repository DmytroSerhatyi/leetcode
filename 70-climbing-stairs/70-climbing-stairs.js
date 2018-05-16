/**
 * @param {number} n
 * @return {number}
 */
var climbStairs = function (n) {
    var a = 1,
        b = 1;

    for (var i = 0; i < n; i++) {
        var temp = a;
        a += b;
        b = temp;
    }

    return b;
};
