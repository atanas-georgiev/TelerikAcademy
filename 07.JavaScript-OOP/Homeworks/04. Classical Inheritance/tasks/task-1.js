/* Task Description */
/* 
	Create a function constructor for Person. Each Person must have:
	*	properties `firstname`, `lastname` and `age`
		*	firstname and lastname must always be strings between 3 and 20 characters, containing only Latin letters
		*	age must always be a number in the range 0 150
			*	the setter of age can receive a convertible-to-number value
		*	if any of the above is not met, throw Error 		
	*	property `fullname`
		*	the getter returns a string in the format 'FIRST_NAME LAST_NAME'
		*	the setter receives a string is the format 'FIRST_NAME LAST_NAME'
			*	it must parse it and set `firstname` and `lastname`
	*	method `introduce()` that returns a string in the format 'Hello! My name is FULL_NAME and I am AGE-years-old'
	*	all methods and properties must be attached to the prototype of the Person
	*	all methods and property setters must return this, if they are not supposed to return other value
		*	enables method-chaining
*/
function solve() {
	'use strict';
	var Person = (function () {
		function Person(firstname, lastname, age) {
			this.firstname = firstname;
			this.lastname = lastname;
			this.age = age;
		}

		Object.defineProperties(Person.prototype, {
				_firstname: {
					value: '',
					enumerable: true,
					configurable: true,
					writable: true
				},
				_lastname: {
					value: '',
					enumerable: true,
					configurable: true,
					writable: true
				},
				_age: {
					value: '',
					enumerable: true,
					configurable: true,
					writable: true
				},
				firstname: {
					get: function() {
						return this._firstname;
					},
					set: function(value) {
						if (/^[a-zA-Z ]+$/.test(value) === false || value.length < 3 || value.length > 20) {
							throw new Error();
						}
						this._firstname = value;
					}
				},
				lastname: {
					get: function() {
						return this._lastname;
					},
					set: function(value) {
						if (/^[a-zA-Z ]+$/.test(value) === false || value.length < 3 || value.length > 20) {
							throw new Error();
						}
						this._lastname = value;
					}
				},
				fullname: {
					get: function() {
						return this.firstname + ' ' + this.lastname;
					},
					set: function(value) {
						this.firstname = value.split(' ')[0];
						this.lastname = value.split(' ')[1];
					}
				},
				age: {
					get: function() {
						return this._age;
					},
					set: function(value) {
						if (isNaN(value) || value < 0 || value > 150) {
							throw new Error();
						}
						this._age = value;
					}
				},
				introduce: {
					value: function() {
						return 'Hello! My name is '+ this.fullname + ' and I am ' + this.age + '-years-old';
					},
					enumerable: true,
					configurable: true,
					writable: true
				}
			}
		);

		return Person;
	} ());
	return Person;
}

module.exports = solve;