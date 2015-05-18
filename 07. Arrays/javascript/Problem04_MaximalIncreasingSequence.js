//Problem 4. Maximal increasing sequence
//
//Write a script that finds the maximal increasing sequence in an array.
//    Example:
//
//input                     result
//3, 2, 3, 4, 2, 2, 4       2, 3, 4

function problem04_MaximalIncreasingSequence() {

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
        if (parseInt(numbers[counter - 1]) < parseInt(numbers[counter])) {
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

