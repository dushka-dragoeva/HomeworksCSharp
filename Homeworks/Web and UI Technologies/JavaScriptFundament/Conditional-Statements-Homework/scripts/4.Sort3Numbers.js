//Sort 3 real values in descending order.
//Use nested if statements.
jsConsole.writeLine('Problem 4. Sort 3 numbers');
function Sort3Numbers(a, b, c) {
    var max = a;
    if (b > max) {
        max = b;
        if (c > max) {
            max = c;
            jsConsole.writeLine(c + ' ' + b + ' ' + a);
            console.log(c + ' ' + b + ' ' + a);
        } else {
            jsConsole.writeLine(b + ' ' + c + ' ' + a);
            console.log(b + ' ' + c + ' ' + a);
        }
    } else {
        if (c > max) {
            max = c;
            jsConsole.writeLine(c + ' ' + a + ' ' + b);
            console.log(c + ' ' + a + ' ' + b);
        }
        else {
            if (b > c) {
                jsConsole.writeLine(a + ' ' + b + ' ' + c);
                console.log(a + ' ' + b + ' ' + c);
            } else {
                jsConsole.writeLine(a + ' ' + c + ' ' + b);
                console.log(a + ' ' + c + ' ' + b);
            }

        }
    }
}
Sort3Numbers(5, 1, 2);
Sort3Numbers(-2, -2, 1);
Sort3Numbers(-2, 4, 3);
Sort3Numbers(0, -2.5, 5);
Sort3Numbers(-1.1, -0.5, -0.1);
Sort3Numbers(10, 20, 30);
Sort3Numbers(1, 1, 1);
jsConsole.writeLine('-----------------------------------------------------------------------------');
