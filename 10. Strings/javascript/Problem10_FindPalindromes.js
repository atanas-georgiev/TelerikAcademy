//Problem 10. Find palindromes
//
//Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".

function isPlaindrome(word) {
    'use strict';

    var i;

    for (i = 0; i < word.length / 2; i += 1) {
        if (word[i] !== word[word.length - i - 1]) {
            return false;
        }
    }
    return true;
}

function problem10_FindPalindromes() {
    'use strict';

    var input =  'ABBA, lamal, exe, sos, not, palindrome, test',
        words = input.split(', ').map(String),
        i,
        result = [];

    for (i = 0; i < words.length; i += 1) {
        if (isPlaindrome(words[i])) {
            result.push(words[i]);
        }
    }

    console.log(result);

}