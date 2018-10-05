/**
 * @param {number} area
 * @return {number[]}
 */
var constructRectangle = function (area) {
    var w = parseInt(Math.sqrt(area));

    while (area % w !== 0) w--;

    return [area / w, w];
};
