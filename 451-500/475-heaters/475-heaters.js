/**
 * @param {number[]} houses
 * @param {number[]} heaters
 * @return {number}
 */
var findRadius = function (houses, heaters) {
    function sorter(a, b) {
        return a - b;
    }

    houses.sort(sorter);
    heaters.sort(sorter);

    var heatersIndex = 0;
    var radius = 0;

    for (var i = 0, l = houses.length; i < l; i++) {
        var heater = heaters[heatersIndex];
        var nextHeater = heaters[heatersIndex + 1];
        var distanceBetweenHeaters = nextHeater === undefined ? Infinity : Math.ceil((nextHeater - heater) / 2);
        var house = houses[i];

        if (house >= heater + distanceBetweenHeaters) {
            heatersIndex++;
            i--;
            continue;
        }

        var candidateRadius = Math.abs(house - heater);

        if (candidateRadius > radius) radius = candidateRadius;
    }

    return radius;
};
