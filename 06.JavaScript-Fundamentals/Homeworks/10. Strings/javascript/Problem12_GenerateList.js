//Problem 12. Generate list
//
//Write a function that creates a HTML <ul> using a template for every HTML <li>.
//The source of the list should be an array of elements.
//    Replace all placeholders marked with –{…}– with the value of the corresponding property of the object.
function problem12_GenerateList() {
    'use strict';

    var template = document.getElementById('list-item').innerHTML,
        ul = document.createElement('ul'),
        i,
        li;

    function format(string, person) {
        return string.replace(/\-{(\w+)\}-/g, function (match, prop) {
            return person[prop] || '';
        });
    }

    var people = [
        {name: 'Pesho', age: 20},
        {name: 'Gosho', age: 21},
        {name: 'Ivo', age: 22},
        {name: 'Nasko', age: 23},
    ];

    for (i in people) {
        li = document.createElement('li');
        li.innerHTML = format(template, people[i]);
        ul.appendChild(li);
    }

    document.body.appendChild(ul);
}