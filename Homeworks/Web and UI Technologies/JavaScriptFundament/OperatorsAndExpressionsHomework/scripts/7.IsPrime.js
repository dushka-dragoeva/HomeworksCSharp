//Proplem 7. Write an expression that checks if given positive integer number n (n ≤ 100) is prime//
jsConsole.writeLine('Problem 7. Is prime')
var input = [1, 2, 3, 4, 9, 37, 97, 51, -3, 0],
    len = input.length,
    number,
    i;
for (i = 0; i < len; i++) {
    number = input[i]
    result = ((number % 2) != 0 && (number % 3) != 0 && (number % 5) != 0 && (number % 7) != 0);
    jsConsole.writeLine('This number ' + number + ' is prime  - ' + result);
    console.log('This number ' + number + ' is prime  - ' + result);
}
jsConsole.writeLine('-----------------------------------------------------------------------------');