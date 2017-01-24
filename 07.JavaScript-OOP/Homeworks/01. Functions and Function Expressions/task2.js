//Write a function that finds all the prime numbers in a range
//It should return the prime numbers in an array
//It must throw an Error if any of the range params is not convertible to Number
//It must throw an Error if any of the range params is missing

function solve() {
    'use strict';
    return function (from, to) {

        function isPrime(number) {
            var start = 2;
            while (start <= Math.sqrt(number)) {
                if (number % start++ < 1) return false;
            }
            return number > 1;
        }

        var cnt,
            isNumber = function (o) {
                return typeof o === 'number' && isFinite(o);
            },
            result = [];

        if (arguments.length === 0 || arguments.length === 1 || from === undefined || to === undefined ||
                !isNumber(from) || !isNumber(to) || from >= to) {
            throw new Error('yes');
        }

        for (cnt = from; cnt <= to; cnt += 1) {
            if (isPrime(cnt)) {
                result.push(cnt);
            }
        }

        return result;
    };
}

var test = solve();
console.log(test(1, 10));