//Probelem 1. Write an expression that checks if given integer is odd or even//
var input = [107, -35, 986, 769, -70, 505];
var len = input.length;
var i;
jsConsole.writeLine(' Problem 1. Odd or Even');
jsConsole.writeLine('Num | Odd?');
for ( i = 0; i < len; i ++) {
    var isOdd = input[i] % 2 ? true : false;
    jsConsole.writeLine(input[i] + ' | ' + isOdd);
    console.log(input[i] + ' isOdd - '+isOdd)
}
jsConsole.writeLine('-----------------------------------------------------------------------------');
