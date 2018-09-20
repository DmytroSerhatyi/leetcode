/**
 * @param {number[][]} grid
 * @return {number}
 */
var islandPerimeter = function (grid) {
    function isEdge(a, b) {
        return !grid[a] || !grid[a][b] || grid[a][b] === 0 ? 1 : 0;
    }

    var result = 0;

    for (var i = 0, l = grid.length; i < l; i++) {
        var row = grid[i];

        for (var j = 0, l0 = row.length; j < l0; j++) {
            var cell = row[j];

            if (cell === 1) {
                result += isEdge(i - 1, j);
                result += isEdge(i + 1, j);
                result += isEdge(i, j - 1);
                result += isEdge(i, j + 1);
            }
        }
    }

    return result;
};
