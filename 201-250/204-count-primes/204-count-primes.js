/**
 * @param {number} n
 * @return {number}
 */
var countPrimes = function (n) {
    var map = new Array(n);
    var counter = 0;

    for (var i = 2; i < n; i++) {
        if (!map[i]) {
            counter++;

            var j = i * i;

            while (j < n) {
                map[j] = true;
                j += i;
            }
        }
    }

    return counter;
};
