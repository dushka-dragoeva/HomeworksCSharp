// Write a script that finds the index of given element in a sorted array of integers by using the binary search algorithm.
jsConsole.writeLine('Problem 7. Binary search')
var midIndex = 0,
    minIndex = 0,
    sortedArr = [-22, -5, 2, 3, 4, 5, 43, 117],
element = 43,
maxIndex = sortedArr.length,
findElement = false;
if (element < sortedArr[midIndex] || element > sortedArr[maxIndex]) {
    console.log('Element is not found.');
    jsConsole.writeLine('Element is not found.');
} else {
    while (maxIndex >= minIndex) {
        midIndex = ((maxIndex + minIndex) / 2) | 0;
        if (sortedArr[midIndex] < element) {
            minIndex = midIndex + 1;
        } else if (sortedArr[midIndex] > element) {
            maxIndex = midIndex - 1;
        }
        else if (sortedArr[midIndex] === element) {
            findElement = true;
            break;
        }
    }
    if (findElement === true) {
        console.log(element + ' has index ' + midIndex);
        jsConsole.writeLine(element + ' has index ' + midIndex);
    }
    else {
        console.log('Element is not found.');
        jsConsole.writeLine('Element is not found.')
    }
}
jsConsole.writeLine('-----------------------------------------------------------------------------');
