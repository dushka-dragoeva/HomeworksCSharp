var Animal = (function () {
    function Animal(name, age) {
        this.name = name;
        this.age = age;
    }
    Animal.prototype.toString = function () {
        return this.name + ' ' + this.age;
    };
    return Animal;
}());

var Cat = (function (parent) {
    function Cat(name, age, sleep) {
        parent.call(this, name, age);
        this.sleep = sleep;
        //return this;
    }
        Cat.prototype = new Animal();
  
        Cat.prototype.toString = function () {
            var baseResult = parent.prototype.toString.call(this);
            return baseResult + ' ' + this.sleep;

        };
     
    return Cat;
}(Animal));

var blackCat = new Cat('Fee', 2, true);

console.log(blackCat);
//var mf = blackCat.toString();
console.log(blackCat.toString());
//console.log(blackCat.toList());
//console.log(mf);