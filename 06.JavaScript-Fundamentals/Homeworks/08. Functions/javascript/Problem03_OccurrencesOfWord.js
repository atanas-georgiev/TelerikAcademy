//Problem 3. Occurrences of word
//
//Write a function that finds all the occurrences of word in a text.
//    The search can be case sensitive or case insensitive.
//    Use function overloading.

function countOccurances(text, word, isCaseSensitive) {
    'use strict';

    var words = text.split(' ').map(String),
        cnt = 0,
        i;

    for (i = 0; i < words.length; i += 1) {
        if (isCaseSensitive) {
            if (words[i] === word) {
                cnt += 1;
            }
        } else {
            if (words[i].toUpperCase() === word.toUpperCase()) {
                cnt += 1;
            }
        }
    }

    return cnt;
}

function problem03_OccurrencesOfWord() {
    'use strict';

    var text = prompt('Enter text: '),
        word = prompt('Enter word to search for: ');

    alert('Word ' + word + ' can be found ' + countOccurances(text, word, false) + ' times in the text');
}