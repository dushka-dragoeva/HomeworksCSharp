//Proplem 6. Write an expression that checks if given point P(x, y) is within a circle K({0,0}, 5). //{0,0} is the centre and 5 is the radius//
jsConsole.writeLine('Problem 6. Point in Circle')
var inputX = [0, -5, -4, 1.5, -4, 100];
var inputY = [1, 0, 5, -3, -3.5, -30];
len = inputX.length;
for (i = 0; i < len; i++) {
    result = ((inputX[i] * inputX[i]) + (inputY[i] * inputY[i]) <= (5 * 5));
    jsConsole.writeLine('The Point {' + inputX[i] + ',' + inputY[i] + '} is inside the circle  -  ' + result);
    console.log('The Point {' + inputX[i] + ',' + inputY[i] + '} is inside the circle  -  ' + result);
}
jsConsole.writeLine('-----------------------------------------------------------------------------');
