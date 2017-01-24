//  Problem 1. Odd or Even
//  Write an expression that checks if given integer is odd or even.

function isOdd(num) {
    return (num % 2 === 0) ? true : false;
}

console.log('----------------------------------------');
console.log('Task 1 output: Odd or Even');
console.log('----------------------------------------');

for (var i = -5; i < 5; i++) {
    console.log("Is " + i + " odd: " + isOdd(i));
}
