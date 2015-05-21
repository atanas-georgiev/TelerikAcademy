//Problem 6.
//
//Write a function that groups an array of people by age, first or last name.
//    The function must return an associative array, with keys - the groups, and values - arrays with people in this groups
//Use function overloading (i.e. just one function)
//
//Example:
//
//    var people = {…};
//var groupedByFname = group(people, 'firstname');
//var groupedByAge= group(people, 'age');

function Person(firstName, lastName, age) {
    'use strict';
    if (!this instanceof Person) {
        return new Person(firstName, lastName, age);
    }

    this.firstname = firstName;
    this.lastname = lastName;
    this.age = age;
}

function groupPersons(array, key) {
    'use strict';
    var result = [],
        i;

    switch (key) {
    case 'firstname':
        for (i = 0; i < array.length; i += 1) {
            result.push(array[i].firstname);
        }
        return result;
    case 'lastname':
        for (i = 0; i < array.length; i += 1) {
            result.push(array[i].lastname);
        }
        return result;
    case 'age':
        for (i = 0; i < array.length; i += 1) {
            result.push(array[i].age);
        }
        return result;
    default:
        return result;
    }
}

function problem06_Persons() {
    'use strict';
    var people = [
        new Person('Pesho', 'Ivanov', 16),
        new Person('Gosho', 'Petrov', 26),
        new Person('Atanas', 'Georgiev', 32),
        new Person('Maria', 'Ivanova', 14)];

    alert('First names: ' + groupPersons(people, 'firstname'));
    alert('Last names: ' + groupPersons(people, 'lastname'));
    alert('Ages: ' + groupPersons(people, 'age'));
}