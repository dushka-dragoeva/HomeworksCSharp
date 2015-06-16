
//Write a script that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
//    Use a sequence of if operators.

jsConsole.writeLine('2. Multiplication Sign');
var a = [5,-2,-2,0,-1],
    b = [2,-2,4,-2.5,-0.5],
    c= [2,1,3,4,-5.1],
    len = a.length,
    i;
for (i = 0; i < len; i++) {
    
    if (a[i]===0 ||b[i]===0||c[i]===0) {
        jsConsole.writeLine(0);
        console.log(0);
    } else {
        if ((a[i] > 0 && b[i] > 0 && c[i] > 0) || (a[i] > 0 && b[i] < 0 && c[i] < 0) || (a[i] < 0 && b[i] < 0 && c[i] > 0) || (a[i] < 0 && b[i] > 0 && c[i] < 0)) {
        jsConsole.writeLine('+');
        console.log('+');
        } else {
            jsConsole.writeLine('-');
            console.log('-');
        }
    }
}
jsConsole.writeLine('-----------------------------------------------------------------------------');
