//Problem 6. Most frequent number
//
//Write a script that finds the most frequent number in an array.
//    Example:
//
//input                                       result
//4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3       4 (5 times)

function problem06_MostFrequentNumber() {

    var numbers = [],
        value,
        i,
        j,
        mostFreq = 0,
        curFreq = 0,
        mostFreqNumber,
        curNumber;

    while (value = prompt('Enter number (Enter to exit)')) {
        numbers.push(parseInt(value));
    }

    mostFreqNumber = numbers[0];
    curNumber = numbers[0];

    // Search for most frequent number
    for (i = 0; i < numbers.length; i++) {
        curFreq = 1;
        curNumber = numbers[i];

        for (j = i + 1; j < numbers.length; j++) {
            if (numbers[j] === curNumber) {
                curFreq++;
            }
        }

        if (curFreq >= mostFreq) {
            mostFreq = curFreq;
            mostFreqNumber = curNumber;
        }
    }

    // Result
    alert('result: ' + mostFreqNumber + ' (' + mostFreq + ') times.');
}