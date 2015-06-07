function Person(firstname, lastname, age, gender) {
    'use strict';
    if (!this instanceof Person) {
        return new Person(firstname, lastname, age, gender);
    }

    this.firstname = firstname;
    this.lastname = lastname;
    this.age = age;
    this.gender = gender;
}

var people1 = [
        new Person('Pesho', 'Ivanov', 16, false),
        new Person('Gosho', 'Petrov', 26, false),
        new Person('Atanas', 'Georgiev', 32, false),
        new Person('Maria', 'Ivanova', 14, true),
        new Person('Plamena', 'Ilieva', 30, true),
        new Person('Ivanka', 'Ivanova', 18, true),
        new Person('Ivan', 'Petrov', 33, false),
        new Person('Georgi', 'Georgiev', 28, false),
        new Person('Maria', 'Ignatova', 24, true),
        new Person('Madlen', 'Lambeva', 14, true)],
    people2 = [
        new Person('Gosho', 'Petrov', 26, false),
        new Person('Atanas', 'Georgiev', 32, false),
        new Person('Plamena', 'Ilieva', 30, true),
        new Person('Ivanka', 'Ivanova', 18, true),
        new Person('Ivan', 'Petrov', 33, false),
        new Person('Georgi', 'Georgiev', 28, false),
        new Person('Maria', 'Ignatova', 24, true)];

//Problem 1. Make person
//
//Write a function for creating persons.
//    Each person must have firstname, lastname, age and gender (true is female, false is male)
//Generate an array with ten person with different names, ages and genders
function problem01_MakePerson() {
    'use strict';
    var result = '';

    people1.forEach(function (item) {
        result += 'Name: ' + item.firstname + ' ' + item.lastname + ' Age: ' + item.age + ' Is female: ' + item.gender + '\n';
    })

    alert(result);
}

//Problem 2. People of age
//
//Write a function that checks if an array of person contains only people of age (with age 18 or greater)
//Use only array methods and no regular loops (for, while)
function problem02_PeopleOfAge() {
    'use strict';

    alert('First array contains only people over 18 years: ' +
        people1.every(function (item) {
            return item.age >= 18;
        }));

    alert('Second array contains only people over 18 years: ' +
        people2.every(function (item) {
            return item.age >= 18;
        }));
}

//Problem 3. Underage people
//
//Write a function that prints all underaged persons of an array of person
//Use Array#filter and Array#forEach
//Use only array methods and no regular loops (for, while)
function problem03_UnderagePeople() {
    'use strict';

    var resultPeople,
        resultStr = '';

    resultPeople = people1.filter(function (item) {
        return item.age < 18;
    })

    resultPeople.forEach(function (item) {
        resultStr += 'Name: ' + item.firstname + ' ' + item.lastname + ' Age: ' + item.age + ' Is female: ' + item.gender + '\n';
    })

    alert(resultStr);
}

//Problem 4. Average age of females
//
//Write a function that calculates the average age of all females, extracted from an array of persons
//Use Array#filter
//Use only array methods and no regular loops (for, while)
function problem04_AverageAgeOfFemales() {
    'use strict';

    var sum = 0,
        count = 0,
        resultPeople;

    resultPeople = people1.filter(function (item) {
        return item.gender === true;
    })

    resultPeople.forEach(function (item) {
        sum += item.age;
        count += 1;
    })

    alert('Average age of females is ' + sum / count);
}

//Problem 5. Youngest person
//
//Write a function that finds the youngest male person in a given array of people and prints his full name
//Use only array methods and no regular loops (for, while)
//    Use Array#find
function problem05_YoungestPerson() {
    'use strict';

    var resultPeople;

    resultPeople = people1.filter(function (item) {
        return item.gender === false;
    }).sort(function (item1, item2) {
        return item1.age - item2.age;
    })

    alert('Youngest male is ' + resultPeople[0].firstname + ' ' + resultPeople[0].lastname);
}

//Problem 6. Group people
//
//Write a function that groups an array of persons by first letter of first name and returns the groups as a JavaScript Object
//Use Array#reduce
//Use only array methods and no regular loops (for, while)
function problem06_GroupPeople() {
    'use strict';

    var resultPeople = people1.reduce(function (obj, item) {
        if (obj[item.firstname[0]]) {
            obj[item.firstname[0]].push(item);
        } else {
            obj[item.firstname[0]] = [item];
        }
        return obj;
    }, {});

    alert(JSON.stringify(resultPeople));
}
