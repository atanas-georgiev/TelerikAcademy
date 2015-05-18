//Problem 1. Numbers
//
//Write a script that prints all the numbers from 1 to N.

function problem01_Numbers() {

    alert('Problem 1. Numbers');

    var n = prompt('N = '),
        i,
        result = [];

    if (n < 1 || isNaN(n)) {
        result = 'Not correct value!';
    } else {
        for (i = 1; i < parseInt(n) + 1; i++) {
            result.push(i);
        }
        result = result.join(', ');
    }

    alert('result = ' + result);

}