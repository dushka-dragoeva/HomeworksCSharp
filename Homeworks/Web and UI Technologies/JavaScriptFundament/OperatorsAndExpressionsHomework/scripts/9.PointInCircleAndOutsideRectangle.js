//Proplem 9.Write an expression that checks for given point P(x, y) if it is within the circle K( (1,1), 3) and 
//out of the rectangle R(top=1, left=-1, width=6, height=2).
jsConsole.writeLine('Problem 9. Point in Circle and outside Rectangle')

var x = [1, 2.5, 0, 2.5, 2, 4, 2.5, 2, 1, -100],
    y = [2, 2, 1, 1, 0, 0, 1.5, 1.5, 2.5, -100],
    len = x.length,
    result,
    i;
for (i = 0; i < len; i++) {
    result = (((((x[i] - 1) * (x[i] - 1)) + ((y[i] - 1) * (y[i] - 1))) <= (3 * 3)) && (y[i] >= 1) && (x[i] <= 2)) ? 'Yes' : 'No';
    jsConsole.writeLine('The Point {' + x[i] + ',' + y[i] + '} is inside the circle and out of the rectangle -  ' + result);
    console.log('The Point {' + x[i] + ',' + y[i] + '} is inside the circle and out of the rectangle -  ' + result);

}
