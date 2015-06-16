//Write a script that finds the greatest of given 5 variables.
//Use nested if statements.
jsConsole.writeLine('7. The biggest of five numbers');
function BiggestOfFive(a, b, c, d, e) {
    var biggest = a;
    if (b > biggest) {
        biggest = b;
        if (c > biggest) {
            biggest = c;
            if (d > biggest) {
                biggest = d;
                if (e > biggest) {
                    biggest = e;
                }
            } else {
                if (e > biggest) {
                    biggest = e;
                }
            }
        } else {
            if (d > biggest) {
                biggest = d;
                if (e > biggest) {
                    biggest = e;
                }
            } else {
                if (e > biggest) {
                    biggest = e;
                }
            }
        }
    } else {
        if (c > biggest) {
            biggest = c;
            if (d > biggest) {
                biggest = d;
                if (e > biggest) {
                    biggest = e;
                }
            } else {
                if (e > biggest) {
                    biggest = e;
                }
            }
        } else {
            if (d > biggest) {
                biggest = d;
                if (e > biggest) {
                    biggest = e;
                }
            } else {
                if (e > biggest) {
                    biggest = e;
                }
            }
        }
    }
        console.log(biggest);
        jsConsole.writeLine(biggest);
}
BiggestOfFive(5, 2, 2, 4, 1);
BiggestOfFive(-2 - 22, 1, 0, 0);
BiggestOfFive(-2, 4, 3, 2, 0);
BiggestOfFive(0, -2.5, 0, 5, 5);
BiggestOfFive(-3 ,-0.5, -1.1, -2,	-0.1)
jsConsole.writeLine('-----------------------------------------------------------------------------');
