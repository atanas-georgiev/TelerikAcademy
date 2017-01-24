//Problem 3. Min/Max of sequence
//
//Write a script that finds the max and min number from a sequence of numbers.

function problem03_MinMaxOfSequence() {

    alert('Min/Max of sequence');

    var numbers = [],
        number,
        min = Number.MAX_VALUE,
        max = Number.MIN_VALUE;

    while (number = prompt('Enter number (Enter to exit)')) {
        numbers.push(parseInt(number));
    }

    for (number in numbers) {
        if (numbers[number] >= max) {
            max = numbers[number];
        }

        if (numbers[number] <= min) {
            min = numbers[number];
        }
    }

    alert('min = ' + min + ' , max = ' + max);

}