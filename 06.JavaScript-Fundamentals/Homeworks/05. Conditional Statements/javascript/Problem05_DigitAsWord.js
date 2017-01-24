//  Problem 5. Digit as word
//
//  Write a script that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English).
//  Print “not a digit” in case of invalid input.
//  Use a switch statement.

function problem05_DigitAsWord() {

    alert('Problem 5. Digit as word');

    var digit = prompt('Enter a digit: '),
        result;

    switch (digit) {
    case '0':
        result = 'Zero';
        break;
    case '1':
        result = 'One';
        break;
    case '2':
        result = 'Two';
        break;
    case '3':
        result = 'Three';
        break;
    case '4':
        result = 'Four';
        break;
    case '5':
        result = 'Five';
        break;
    case '6':
        result = 'Six';
        break;
    case '7':
        result = 'Seven';
        break;
    case '8':
        result = 'Eight';
        break;
    case '9':
        result = 'Nine';
        break;
    default:
        result = 'not a digit';
        break;
    }

    alert('result: ' + result);

}