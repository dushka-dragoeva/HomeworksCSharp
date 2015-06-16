//Proplem 5. Write a boolean expression for finding if the bit #3 (counting from 0) of a given integer.
//The bits are counted from right to left, starting from bit #0. The result of the expression should be either 1 or 0.
jsConsole.writeLine('Problem 5. Third bit')
var input = [5, 8, 0, 15, 5343, 62241],
len = input.length,
result,
i;

for (i = 0; i < len; i++) {
    result = Number(input[i] >> 3) & 1 ? 1 : 0;
    jsConsole.writeLine(input[i] + '---' + Number(input[i]).toString(2) + ' bit#3 = ' + result);
    console.log(input[i] + ' binary: ' + Number(input[i]).toString(2) + ' bit#3 = ' + result);
}
jsConsole.writeLine('-----------------------------------------------------------------------------');