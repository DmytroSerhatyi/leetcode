/**
 * @param {number} rowIndex
 * @return {number[]}
 */
var getRow = function (rowIndex) {
    var result = [1];

    if (rowIndex === 0) return result;

    var helper = [1, 1];

    for (var i = 1; i < rowIndex; i++) {
        var operating = result.length > helper.length ? result : helper;
        var operated = result.length > helper.length ? helper : result;

        for (var j = 1; j <= i; j++) {
            operated[j] = operating[j] + operating[j - 1];
        }

        operated.push(1);
    }

    return result.length > helper.length ? result : helper;
};
