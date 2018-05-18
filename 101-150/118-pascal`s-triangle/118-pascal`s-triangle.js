/**
 * @param {number} numRows
 * @return {number[][]}
 */
var generate = function (numRows) {
    var result = [];

    if (numRows === 0) return result;

    result.push([1]);

    for (var i = 1; i < numRows; i++) {
        var lastArray = result[i - 1];
        var newArray = [1];

        for (var j = 1; j < i; j++) {
            newArray.push(lastArray[j - 1] + lastArray[j]);
        }

        newArray.push(1);
        result.push(newArray);
    }

    return result;
};
