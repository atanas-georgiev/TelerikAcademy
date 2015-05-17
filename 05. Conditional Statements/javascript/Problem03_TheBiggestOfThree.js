//  Problem 3. The biggest of Three
//
//  Write a script that finds the biggest of three numbers.
//  Use nested if statements.

(function () {

    var a = -0.1,
        b = -1.1,
        c = -2,
        result;

    console.log('----------------------------------------');
    console.log('Problem 3. The biggest of Three');
    console.log('----------------------------------------');

    console.log('a = ' + a + ',b = ' + b + ',c = ' + c);

    if (a >= b) {
        if (a >= c) {
            result = a;
        } else {
            result = c;
        }
    } else {
        if (b >= c) {
            result = b;
        } else {
            result = c;
        }
    }

    console.log('result: ' + result);

})();