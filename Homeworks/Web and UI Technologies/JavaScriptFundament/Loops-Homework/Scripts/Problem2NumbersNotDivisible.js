//Write a script that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time
jsConsole.writeLine('Problem 2. Numbers not divisible')
var maxNumber = prompt('2.Please enter a number: '),
    number = 1
    numberStr='';
maxNumber = +maxNumber;
while (number <= maxNumber) {
    if((number%3)||(number%7)){
        numberStr += number + ', ';
    }
    number += 1;
}
console.log(numberStr);
jsConsole.writeLine(numberStr);
jsConsole.writeLine('-----------------------------------------------------------------------------');

