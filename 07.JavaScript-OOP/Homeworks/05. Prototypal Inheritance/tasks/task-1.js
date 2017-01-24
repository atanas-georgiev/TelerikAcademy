/* Task Description */
/*
* Create an object domElement, that has the following properties and methods:
  * use prototypal inheritance, without function constructors
  * method init() that gets the domElement type
    * i.e. `Object.create(domElement).init('div')`
  * property type that is the type of the domElement
    * a valid type is any non-empty string that contains only Latin letters and digits
  * property innerHTML of type string
    * gets the domElement, parsed as valid HTML
      * <type attr1="value1" attr2="value2" ...> .. content / children's.innerHTML .. </type>
  * property content of type string
    * sets the content of the element
    * works only if there are no children
  * property attributes
    * each attribute has name and value
    * a valid attribute has a non-empty string for a name that contains only Latin letters and digits or dashes (-)
  * property children
    * each child is a domElement or a string
  * property parent
    * parent is a domElement
  * method appendChild(domElement / string)
    * appends to the end of children list
  * method addAttribute(name, value)
    * throw Error if type is not valid
  * method removeAttribute(attribute)
    * throw Error if attribute does not exist in the domElement
*/


/* Example

var meta = Object.create(domElement)
    .init('meta')
    .addAttribute('charset', 'utf-8');

var head = Object.create(domElement)
    .init('head')
    .appendChild(meta)

var div = Object.create(domElement)
    .init('div')
    .addAttribute('style', 'font-size: 42px');

div.content = 'Hello, world!';

var body = Object.create(domElement)
    .init('body')
    .appendChild(div)
    .addAttribute('id', 'cuki')
    .addAttribute('bgcolor', '#012345');

var root = Object.create(domElement)
    .init('html')
    .appendChild(head)
    .appendChild(body);

console.log(root.innerHTML);
Outputs:
<html><head><meta charset="utf-8"></meta></head><body bgcolor="#012345" id="cuki"><div style="font-size: 42px">
Hello, world!</div></body></html>
*/


function solve() {
    'use strict';
    var domElement = (function () {
        var domElement = {
            init: function (type) {
                if (type === undefined || type === '' || typeof type !== 'string' ||
                        /^[a-zA-Z0-9_]+(,[a-zA-Z0-9_]+)*$/.test(type) === false) {
                    throw new Error();
                }
                this.type = type;
                this.content = '';
                this.attibutes = [];
                this.children = [];
                this.parent = {};
                return this;
            },

            appendChild: function (child) {
                if (typeof child === 'string') {
                    var newObj = Object.create(domElement).init('emptyElement');
                    newObj.content = child;
                    this.children.push(newObj);
                } else {
                    child.parent = this;
                    this.children.push(child);
                }

                return this;
            },

            addAttribute: function (name, value) {
                if (name === undefined || /^[a-zA-Z0-9\-]+(,[a-zA-Z0-9\-]+)*$/.test(name) === false) {
                    throw new Error();
                }

                this.attibutes[name] = value;
                return this;
            },

            removeAttribute: function (name) {
                if (this.attibutes[name] === undefined) {
                    throw new Error();
                }

                delete this.attibutes[name];
                return this;
            },

            get innerHTML() {
                var output = '',
                    i,
                    len,
                    keys = Object.keys(this.attibutes);

                if (this.type !== 'emptyElement') {
                    output += '<' + this.type;
                    keys.sort();
                    for (i = 0, len = keys.length; i < len; i += 1) {
                        output += ' ' + keys[i] + '="' + this.attibutes[keys[i]] + '"';
                    }

                    output += '>';
                    len = this.children.length;

                    if (len === 0) {
                        output += this.content;
                    } else {
                        for (i = 0; i < len; i += 1) {
                            output += this.children[i].innerHTML;
                        }
                    }

                    output += '</' + this.type + '>';
                } else {
                    output = this.content;
                }

                return output;
            }
        }

        return domElement;
    } ());
    return domElement;
}

module.exports = solve;
