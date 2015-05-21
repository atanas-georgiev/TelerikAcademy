//Problem 5. Youngest person
//
//Write a function that finds the youngest person in a given array of people and prints his/hers full name
//Each person has properties firstname, lastname and age.
//
//    Example:
//
//var people = [
//    { firstname : 'Gosho', lastname: 'Petrov', age: 32 },
//    { firstname : 'Bay', lastname: 'Ivan', age: 81},… ];

function Person(firstName, lastName, age) {
    'use strict';
    if (!this instanceof Person) {
        return new Person(firstName, lastName, age);
    }

    this.firstname = firstName;
    this.lastname = lastName;
    this.age = age;
}

function findYoungestPerson(array) {
    'use strict';
    var i,
        youngest = new Person('', '', Number.MAX_VALUE);

    for (i = 0; i < array.length; i += 1) {
        if (array[i] instanceof Person) {
            if (array[i].age < youngest.age) {
                youngest.firstname = array[i].firstname;
                youngest.lastname = array[i].lastname;
                youngest.age = array[i].age;
            }
        }
    }

    if (youngest.firstname === '') {
        return 'Not found';
    } else {
        return youngest.firstname + ' ' + youngest.lastname;
    }
}

function problem05_YoungestPerson() {
    'use strict';
    var people = [
        new Person('Pesho', 'Ivanov', 16),
        new Person('Gosho', 'Petrov', 26),
        new Person('Atanas', 'Georgiev', 32),
        new Person('Maria', 'Ivanova', 14)];

    alert('Youngest person is: ' + findYoungestPerson(people));
}