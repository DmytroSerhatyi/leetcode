/**
 * @param {number} buckets
 * @param {number} minutesToDie
 * @param {number} minutesToTest
 * @return {number}
 */
var poorPigs = function (buckets, minutesToDie, minutesToTest) {
    var result = 0;
    var rounds = minutesToTest / minutesToDie + 1;
    var calcs = 1;

    while (calcs < buckets) {
        result++;
        calcs *= rounds;
    }

    return result;
};
