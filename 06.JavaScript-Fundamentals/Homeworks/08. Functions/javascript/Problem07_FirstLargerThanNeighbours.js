//Problem 7. First larger than neighbours
//
//Write a function that returns the index of the first element in array that is larger than its neighbours or -1, if there’s no such element.
//    Use the function from the previous exercise.

function getFirstLargerThanNeighbours(array) {
    'use strict';

    var i;

    for (i = 0; i < array.length; i += 1) {
        if (isLargerThanNeighbours(array, i)) {
            return i;
        }
    }

    return -1;
}

function problem07_FirstLargerThanNeighbours() {
    'use strict';

    var value,
        numbers = [],
        index;

    while (value = prompt('Enter number in array (Enter to exit)')) {
        numbers.push(parseInt(value));
    }

    alert('Position of first element larger than neighbours is ' + getFirstLargerThanNeighbours(numbers));
}