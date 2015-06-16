//Proplem 8. Write an expression that calculates trapezoid's area by given sides a and b and height h.//
jsConsole.writeLine('Problem 8. Trapezoid area')
var a = [5, 2, 8.5, 100, 0.222],
    b = [7, 1, 4.3, 200, 0.333],
    h = [12, 33, 2.7, 300, 0.555]
    area;
    len = a.length;
    i;
for (i = 0; i < len; i++) {
    area = (((a[i] + b[i]) / 2) * h[i]).toPrecision(1 + 6);
    jsConsole.writeLine('a = ' + a[i] + ', b = ' + b[i] + ', h = ' + h[i] + ', area = ' + area);
    console.log('a = ' + a[i] + ', b = ' + b[i] + ', h = ' + h[i] + ', area = ' + area);
}
jsConsole.writeLine('-----------------------------------------------------------------------------');