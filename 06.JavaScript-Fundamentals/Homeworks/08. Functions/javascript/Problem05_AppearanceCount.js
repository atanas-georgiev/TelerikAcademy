//Problem 5. Appearance count
//
//Write a function that counts how many times given number appears in given array.
//    Write a test function to check if the function is working correctly.

function countAppearanceElement(array, element) {
    'use strict';
    var index,
        cnt = 0;

    if (!isNaN(element)) {
        for (index = 0; index < array.length; index += 1) {
            if (element === array[index]) {
                cnt += 1;
            }
        }
    } else {
        cnt = 0;
    }

    return cnt;
}

function problem05_AppearanceCount() {
    'use strict';

    var value,
        numbers = [],
        numberToSearch;

    while (value = prompt('Enter number in array (Enter to exit)')) {
        numbers.push(parseInt(value));
    }

    numberToSearch = prompt('Enter number to search for');

    alert ('Number ' + numberToSearch + ' can be found ' + countAppearanceElement(numbers, parseInt(numberToSearch)) + ' times in the array');

}