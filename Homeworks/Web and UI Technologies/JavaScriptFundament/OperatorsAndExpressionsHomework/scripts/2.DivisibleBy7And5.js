//Proplem 2 . Write an expression that checks if given integer is odd or even.//
var input = [107, -35, 986, 769, -70, 505];
var len = input.length;
var i = 1;
jsConsole.writeLine('Problem 2. Divisible by 7 and 5');
jsConsole.writeLine('Num | Divisible by 7 and 5?');
for (i = 0; i < len; i++) {
    var isDivisable5 = input[i] % 5 ? false : true;
    var isDivisable7 = input[i] % 7 ? false : true;
    var isDivisable5And7 = isDivisable5 && isDivisable7 ? true : false;
    jsConsole.writeLine(input[i] + ' | ' + isDivisable5And7);
    console.log(input[i] + ' Divisible by 7 and 5? - ' + isDivisable5And7);
}
jsConsole.writeLine('-----------------------------------------------------------------------------');