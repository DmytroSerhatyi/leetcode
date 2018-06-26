/**
 * @param {number} n
 * @return {string[]}
 */
var fizzBuzz = function (n) {
    var result = [];
    var fizz = 'Fizz';
    var buzz = 'Buzz';

    for (var i = 1; i <= n; i++) {
        if (i % 15 === 0) result.push(fizz + buzz);
        else if (i % 5 === 0) result.push(buzz);
        else if (i % 3 === 0) result.push(fizz);
        else result.push(i.toString());
    }

    return result;
};
