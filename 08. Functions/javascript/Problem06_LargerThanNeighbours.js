//Problem 6. Larger than neighbours
//
//Write a function that checks if the element at given position in given array of integers is bigger than its two neighbours (when such exist).

function isLargerThanNeighbours(array, index) {
    'use strict';

    if (index === 0) {
        return (array[index] > array[index + 1]);
    } else if (index === array.length - 1) {
        return (array[index] > array[index - 1]);
    } else {
        return (array[index] > array[index - 1] && (array[index] > array[index + 1]));
    }
}

function problem06_LargerThanNeighbours() {
    'use strict';

    var value,
        numbers = [],
        index;

    while (value = prompt('Enter number in array (Enter to exit)')) {
        numbers.push(parseInt(value));
    }

    index = parseInt(prompt('Enter index'));

    alert('Element at position ' + index + ' bigger than neighbours? ' + isLargerThanNeighbours(numbers, index));
}