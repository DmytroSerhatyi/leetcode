/**
 * @param {number[][]} points
 * @return {number}
 */
var numberOfBoomerangs = function (points) {
    var result = 0;
    var l = points.length;

    for (var i = 0, il = l - 2; i < il; i++) {
        var point1 = points[i];

        for (var j = i + 1, jl = l - 1; j < jl; j++) {
            var point2 = points[j];
            var between1And2 = calculateDistance(point1, point2);

            for (var k = j + 1; k < l; k++) {
                var point3 = points[k];
                var between1And3 = calculateDistance(point1, point3);
                var between2And3 = calculateDistance(point2, point3);

                if (between1And2 === between1And3) result += 2;
                if (between1And2 === between2And3) result += 2;
                if (between1And3 === between2And3) result += 2;
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
