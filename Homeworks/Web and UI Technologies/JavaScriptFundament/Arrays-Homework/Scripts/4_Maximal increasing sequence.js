//Write a script that finds the maximal increasing sequence in an array.
jsConsole.writeLine('Problem 4. Maximal increasing sequence')
var i,
    startIndex,
    endIndex,
    result,
    arr = [3, 2, 3, 4, 2, 2, 4],
    len = arr.length,
    length = 1,
    bestLength = 1;
for (i = 0; i < len; i += 1) {
    if (arr[i] < arr[i + 1]) {
        length++;
    }
    else {
        length = 1;
    }
    if (length >= bestLength) {
        bestLength = length;
        endIndex = i + 1;
    }
}
startIndex = endIndex - (bestLength - 1);
result = arr.slice(startIndex, endIndex + 1)
console.log(result);
jsConsole.writeLine(result);
jsConsole.writeLine('-----------------------------------------------------------------------------');