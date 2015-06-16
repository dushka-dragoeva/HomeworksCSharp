//Write a script that finds the biggest of three numbers.
//Use nested if statements.
jsConsole.writeLine('Problem 3. The biggest of Three');
var a = [5, -2, -2, 0, -0.1],
    b = [2, -2, 4, -2.5, -0.5],
    c = [2, 1, 3, 5, -1.1],
    len = a.length,
    max, i;
for (i = 0; i < len; i++) {
    max = a[i];
    if (b[i] > max) {
        max = b[i];
        if (c[i] > max) {
            max = c[i];
        } 
    }else {
        if (c[i] > max) {
            max=c[i]
    }
    }
    jsConsole.writeLine(max);
    console.log(max);
}
jsConsole.writeLine('-----------------------------------------------------------------------------');
