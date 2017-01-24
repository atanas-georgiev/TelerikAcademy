//Problem 3. Maximal sequence
//
//Write a script that finds the maximal sequence of equal elements in an array.
//    Example:
//
//input                          result
//2, 1, 1, 2, 3, 3, 2, 2, 2, 1   2, 2, 2

//Problem 2. Lexicographically comparison
//
//Write a script that compares two char arrays lexicographically (letter by letter).

function problem03_MaximalSequence() {

    var numbers = [],
        value,
        counter = 0,
        maximalCnt = 0,
        maximalIndex = 0,
        currentCnt = 0;

    while (value = prompt('Enter number (Enter to exit)')) {
        numbers.push(parseInt(value));
    }

    for (counter = 1; counter < numbers.length; counter++) {
        if (parseInt(numbers[counter - 1]) === parseInt(numbers[counter])) {
            currentCnt++;
        } else if (currentCnt > maximalIndex) {
            maximalCnt = currentCnt + 1;
            maximalIndex = counter - currentCnt - 1;
            currentCnt = 0;
        } else {
            currentCnt = 0;
        }
    }

    if (currentCnt > maximalIndex) {
        maximalCnt = currentCnt + 1;
        maximalIndex = counter - currentCnt - 1;
    }

    alert('result: ' + numbers.slice(maximalIndex, maximalIndex + maximalCnt));
}
