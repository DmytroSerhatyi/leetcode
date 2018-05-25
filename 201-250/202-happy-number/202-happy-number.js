/**
 * @param {number} n
 * @return {boolean}
 */
var isHappy = function (n) {
    var fast = n;
    var slow = n;

    do {
        slow = digitSquareSum(slow);
        fast = digitSquareSum(digitSquareSum(fast));
    } while (slow != fast);

    return slow === 1;
};

function digitSquareSum(n) {
    var sum = 0;
    var temp;

    while (n) {
        temp = n % 10;
        sum += temp * temp;
        n = (n - temp) / 10;
    }

    return sum;
}
