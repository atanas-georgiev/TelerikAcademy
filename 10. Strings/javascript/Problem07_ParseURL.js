//Problem 7. Parse URL
//
//Write a script that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.
//Return the elements in a JSON object.

function xIndexOf(Val, Str, x) {
    'use strict';

    var Ot,
        i;

    if (x <= (Str.split(Val).length - 1)) {
        Ot = Str.indexOf(Val);
        if (x > 1) {
            for (i = 1; i < x; i += 1) {
                Ot = Str.indexOf(Val, Ot + 1);
            }
        }
        return Ot;
    } else {
        alert(Val + " Occurs less than " + x + " times");
        return 0;
    }
}

function problem07_ParseURL() {
    'use strict';
    var input = 'http://telerikacademy.com/Courses/Courses/Details/239',
        index1 = xIndexOf('/', input, 2),
        index2 = xIndexOf('/', input, 3),
        data = {
            protocol: input.substring(0, index1 - 2),
            server: input.substring(index1 + 1, index2),
            resourse: input.substring(index2 + 1, input.length)
        }

    console.log(data);
}