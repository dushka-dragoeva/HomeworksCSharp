function solve() {

    var domElement = (function () {

        function validateType(type) {
            if (typeof type !== 'string') {
                throw new Error('Invalid string!');
            }
            return /^[A-Z0-9]+$/i.test(type);
        }

        function validateAttribute(name) {

            if (typeof name !== 'string') {
                throw new Error('Invalid string!');
            }
            return /^[A-Z0-9\-]+$/i.test(name);
        }
        function isEmptyObject(obj) {
            for (var prop in obj) {
                if (obj.hasOwnProperty(prop)) {
                    return false;
                }
            }

            return true;
        }

        function getSortedAttributes(attributes) {
            var attributesString = '',
                key,
                i,
                len,
                currentKey,
                keys = [];

            for (key in attributes) {

                keys.push(key);
            }

            keys.sort();

            for ( i = 0, len = keys.length; i < len; i += 1) {
                currentKey = keys[i];
                attributesString += ' ' + currentKey + '="' + attributes[currentKey] + '"';
            }

            return attributesString;
        }

        function createInnerHtml(element) {

            var child,
                i,
                len,
                innerHtml = '<' + element.type + getSortedAttributes(element.attributes) + '>';

            for (i = 0, len = element.children.length; i < len; i += 1) {
                child = element.children[i];

                if (typeof child === 'string') { //||(typeof str == "object" && str.constructor === String)) {
                    innerHtml += child;
                } else {
                    innerHtml += child.innerHTML;
                }
            }

            innerHtml += element.content;
            innerHtml += '</' + element.type + '>';

            return innerHtml;

        }



        var domElement = {
            init: function (type) {
                this.type = type;
                this.content = '';
                this.parent;
                this.children = [];
                this.attributes = [];

                return this;
            },


            appendChild: function (child) {
                this.children.push(child);

                if (typeof child === 'object') {
                    child.parent = this;
                }

                return this;
            },


            addAttribute: function (name, value) {
                if (!validateAttribute(name)) {
                    throw new Error('Attribute must contains only Latin letters,digits and "-"!');
                }
                this.attributes[name] = value;
                return this;
            },

            removeAttribute: function (attribute) {
                if (!this.attributes[attribute]) {
                    throw new Error('This attribute does not exist.');
                }

                delete this.attributes[attribute];

                return this;
            },

            get innerHTML() {
                //var child,
                //i,
                //len,
                //innerHtml = '<' + this.type + getSortedAttributes(this.attributes) + '>';

                //for (i = 0, len = this.children.length; i < len; i += 1) {
                //    child = this.children[i];

                //    if (typeof child === 'string' ) { // || (typeof str == "object" && str.constructor === String))/ {
                //        innerHtml += child;
                //    } else {
                //        innerHtml += child.innerHTML;
                //    }
                //}

                //innerHtml += this.content;
                //innerHtml += '</' + this.type + '>';

                //return innerHtml;



                return createInnerHtml(this);
            },

            get type() {
                return this._type;
            },
            set type(value) {
                if (!validateType(value)) {
                    throw new Error('Invalid type.');
                }

                this._type = value;
            },

            get content() {
                if (this.children.length) {
                    return '';
                }
                return this._content;
            },
            set content(value) {
                 if (!this.hasChildren) {
                    this._content = value;
                }
                this._content = value;
            },

            get attributes() {
                return this._attributes;
            },
            set attributes(value) {
                this._attributes = value;
            },

            get children() {
                return this._children;
            },
            set children(value) {
                this._children = value;
            },
            get parent() {
                return this._parent;
            },
            set parent(value) {
                this._parent = value;
            }

        };
        return domElement;
    }());
    return domElement;
}

var domElement = solve();

var meta = Object.create(domElement)
    .init('meta')
    .addAttribute('charset', 'utf-8');

var head = Object.create(domElement)
    .init('head')
    .appendChild(meta);

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

console.log(head.parent);
console.log(root.innerHTML);