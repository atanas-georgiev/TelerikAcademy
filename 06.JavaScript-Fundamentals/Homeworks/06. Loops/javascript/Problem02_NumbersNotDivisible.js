//Problem 2. Numbers not divisible
//
//Write a script that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time

function problem02_NumbersNotDevisible() {

    alert('Problem 2. Numbers not divisible');

    var n = prompt('N = '),
        i,
        result = [];

    if (n < 1 || isNaN(n)) {
        result = 'Not correct value!';
    } else {
        for (i = 1; i < parseInt(n) + 1; i++) {
            if ((i % 3 !== 0) && (i % 7 !== 0)) {
                result.push(i);
            }
        }
        result = result.join(', ');
    }

    alert('result = ' + result);

}