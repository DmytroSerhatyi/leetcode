/**
 * @param {number[][]} points
 * @return {number}
 */
var numberOfBoomerangs = function (points) {
    var result = 0;
    var l = points.length;

    for (var i = 0; i < l; i++) {
        var point1 = points[i];
        var map = {};

        for (var j = 0; j < l; j++) {
            if (i === j) continue;

            var point2 = points[j];
            var distance = calculateDistance(point1, point2);

            var count = map[distance];

            if (count) {
                map[distance]++;
            } else {
                map[distance] = 1;
            }
        }

        for (var key in map) {
            if (!map.hasOwnProperty(key)) continue;

            var val = map[key];

            if (val > 1) {
                result += val * (val - 1);
            }
        }
    }

    return result;
};

function calculateDistance(p1, p2) {
    var sub1 = p1[0] - p2[0];
    var sub2 = p1[1] - p2[1];

    return sub1 * sub1 + sub2 * sub2;
}
