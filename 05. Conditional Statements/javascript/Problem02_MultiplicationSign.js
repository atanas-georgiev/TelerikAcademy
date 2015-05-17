//  Problem 2. Multiplication Sign
//
//    Write a script that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
//    Use a sequence of if operators.

function problem02_MultiplicationSign() {

    var a = -2,
        b = 4,
        c = 3,
        result;

    console.log('----------------------------------------');
    console.log('Problem 2. Multiplication Sign');
    console.log('----------------------------------------');

    console.log('a = ' + a + ',b = ' + b + ',c = ' + c);

    if (a === 0 || b === 0 || c === 0) {
        result = '0';
    } else if (a > 0) {
        if (b > 0) {
            if (c > 0) {
                result = '+';
            } else {
                result = '-';
            }
        } else {
            if (c > 0) {
                result = '-';
            } else {
                result = '+';
            }
        }
    } else {
        if (b > 0) {
            if (c > 0) {
                result = '-';
            } else {
                result = '+';
            }
        } else {
            if (c > 0) {
                result = '+';
            } else {
                result = '-';
            }
        }
    }

    console.log('result: ' + result);

}