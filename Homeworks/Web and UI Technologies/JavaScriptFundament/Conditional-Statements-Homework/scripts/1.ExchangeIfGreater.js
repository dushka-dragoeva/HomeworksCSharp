
//Write an if statement that takes two double variables a and b and exchanges their values if the first one is greater than the second.
//As a result print the values a and b, separated by a space.
jsConsole.writeLine('Problem 1. Exchange if greater');
var a = [5, 3, 5.5],
    b = [2, 4, 4.5],
    len = a.length,
    max, i;
for (i = 0; i < len; i++) {
       max = a[i];
    if (b[i] >= max) {
        jsConsole.writeLine(b[i] + ' ' + a[i]);
        console.log(b[i] + ' ' + a[i]);
    } else {
        jsConsole.writeLine(a[i] + ' ' + b[i])
        console.log(a[i] + ' ' + b[i]);
    }
}
jsConsole.writeLine('-----------------------------------------------------------------------------');
