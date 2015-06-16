//Write a script that prints all the numbers from 1 to N.
jsConsole.writeLine('Problem 1. Numbers')
var maxNumber = prompt('1.Please enter a number: '),
    number=1;
maxNumber = +maxNumber
numberStr='';
while (number <= maxNumber) {
   // console.log(number);
    // jsConsole.writeLine(number);
    numberStr += number +', ';
    number += 1;
}
console.log(numberStr);
jsConsole.writeLine(numberStr);
jsConsole.writeLine('-----------------------------------------------------------------------------');

