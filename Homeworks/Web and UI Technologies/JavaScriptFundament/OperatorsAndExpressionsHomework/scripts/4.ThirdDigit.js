//Proplem 4. Write an expression that checks for given integer if its third digit (right-to-left) is 7.//
jsConsole.writeLine('Problem 4. Third digit');
var input = [5, 701, 1732, 9703, 877, 777877, 9999799],
    len = input.length,
    result,
    i;
for (i = 0; i < len; i++) {
    result = ((input[i] / 100) | 0) % 10 === 7;
    jsConsole.writeLine(input[i] + ' Third digit is 7? - ' + result);
    console.log(input[i] + ' Third digit is 7? - ' + result);
}
jsConsole.writeLine('-----------------------------------------------------------------------------');