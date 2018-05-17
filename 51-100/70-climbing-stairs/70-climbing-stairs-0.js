/**
 * @param {number} n
 * @return {number}
 */
var climbStairs = function (n) {
    var result = 0;
    var counter = 0;
    var min = Math.ceil(n / 2);

    while (n >= min) {
        result += factor(n) / (factor(n - counter) * factor(counter));
        n--;
        counter++;
    }

    return result;
};

function factor(x) {
    var result = 1;

    for (var i = 2; i <= x; i++) {
        result *= i;
    }

    return result;
}
