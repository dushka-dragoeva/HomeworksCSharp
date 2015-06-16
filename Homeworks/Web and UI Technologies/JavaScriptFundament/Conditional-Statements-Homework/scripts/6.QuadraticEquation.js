//Write a script that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).
//    Calculates and prints its real roots.
jsConsole.writeLine('Problem 6. Quadratic equation');
function QuadraticEquation(a, b, c) {
    var deskriminant = (b * b) - (4 * a * c);
    if (deskriminant > 0) {
        var x1 = (-b - Math.sqrt(deskriminant)) / (2 * a)
        var x2 = (-b + Math.sqrt(deskriminant)) / (2 * a)
        jsConsole.writeLine('x1 = ' + x1 + ' x2 = ' + x2);
        console.log('x1 = ' + x1 + ' x2 = ' + x2);
    } else {
        if (deskriminant == 0) {
            x1 = (-b) / (2 * a)
            x2 = x1;
            jsConsole.writeLine('x1 = x2 = ' + x1);
            console.log('x1 = ' + x1 + ' x2 = ' + x2);
        } else {
            console.log('no real roots');
            jsConsole.writeLine('no real roots');
        }
    }
}
QuadraticEquation(2, 5, -3);
QuadraticEquation(-1, 3, 0);
QuadraticEquation(-0.5, 4, -8);
QuadraticEquation(5, 2, 8);

jsConsole.writeLine('-----------------------------------------------------------------------------');
