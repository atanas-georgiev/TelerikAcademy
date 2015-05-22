//Problem 1. Reverse string
//
//Write a JavaScript function that reverses a string and returns it.
//    Example:
//
//input    output
//sample   elpmas

function reverseString(input) {
    'use strict';
    if ((typeof input) !== 'string') {
        throw new Error('Input is not a string!');
    }
    return input.split('').reverse().join('');
}

function problem01_ReverseString() {
    'use strict';
    alert('Inverted string is: ' + reverseString(prompt('Enter a string value')));
}