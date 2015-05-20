//Problem 2. Reverse number
//
//Write a function that reverses the digits of given decimal number.
//    Example:
//
//input   output
//256     652
//123.45  54.321

function reverseNumber(number) {
    'use strict';

    var retValue = '',
        i;

    if (isNaN(number)) {
        retValue = 0;
    } else {
        for (i = number.length - 1; i >= 0; i -= 1) {
            retValue += number[i];
        }
    }

    return retValue;
}

function problem02_ReverseNumber() {
    'use strict';
    alert('Number reversed: ' + reverseNumber(prompt('Enter number: ')));
}