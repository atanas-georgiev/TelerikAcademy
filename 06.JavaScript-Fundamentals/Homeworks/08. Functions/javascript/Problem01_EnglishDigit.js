//Problem 1. English digit
//
//Write a function that returns the last digit of given integer as an English word.
//    Examples:
//
//input output
//512   two
//1024  four
//12309 nine

function getLestDigit(number) {
    'use strict';

    switch (number[number.length - 1]) {
    case '0':
        return 'zero';
    case '1':
        return 'one';
    case '2':
        return 'two';
    case '3':
        return 'three';
    case '4':
        return 'four';
    case '5':
        return 'five';
    case '6':
        return 'six';
    case '7':
        return 'seven';
    case '8':
        return 'eight';
    case '9':
        return 'nine';
    default:
        return 'invalid number';
    }
}

function problem01_EnglishDigit() {
    'use strict';
    alert('Last digit is: ' + getLestDigit(prompt('Enter number')));
}