//Write a function that sums an array of numbers:
//    Numbers must be always of type Number
//Returns null if the array is empty
//Throws Error if the parameter is not passed (undefined)
//Throws if any of the elements is not convertible to Number

function solve() {
    'use strict';
    return function (arr) {
        var isNumber = function (o) {
                return typeof o === 'number' && isFinite(o);
            },
            sum = 0,
            element;

        if (arr === undefined) {
            throw new Error('Input is undefined!');
        }

        if (arr.length === 0) {
            return null;
        }

        for (element in arr) {
            if (arr.hasOwnProperty(element)) {
                if (!isNumber(arr[element])) {
                    throw new Error('yes');
                }
                sum += parseFloat(arr[element], 10);
            }
        }
        return sum;
    };
}

var test = solve();
console.log(test([1, 2, 3, 4, 5]));