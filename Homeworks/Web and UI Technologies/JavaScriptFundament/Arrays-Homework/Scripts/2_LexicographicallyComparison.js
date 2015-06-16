//Write a script that compares two char arrays lexicographically (letter by letter)
jsConsole.writeLine('Problem 2. Lexicographically comparison')
var i,
    resultStr,
    areEqual = true;
firstArr = ['a', 'g', 'd', 'g', 'h', 'f', 'g'],
secondArr = ['a', 'b', 'd', 'g', 'h', 'f', 'g'],
firstLen = firstArr.length,
secondLen = secondArr.length;

if (firstLen != secondLen) {
    resultStr = 'Two arrays have different lenght.'
}
else {
    resultStr = 'Two arrays have equal lenght '
    for (i = 0; i < firstLen; i++) {
        if (firstArr[i] != secondArr[i]) {
            areEqual = false;
            break;
        }
    }
}
if (areEqual) {
    resultStr += 'and equal elements.';
} else {
    resultStr += 'but different elements.';
}
console.log(resultStr);
jsConsole.writeLine(resultStr);
jsConsole.writeLine('-----------------------------------------------------------------------------');