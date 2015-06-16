//Sorting an array means to arrange its elements in increasing order.
//Write a script to sort an array.
//Use the selection sort algorithm: Find the smallest element, move it at the first position, 
//find the smallest from the rest, move it at the second position, etc.
//    Hint: Use a second array
jsConsole.writeLine('Problem 5. Selection sort')
var i,
    j,
    sortedArr = [],
    comparedElement,
    minIndex,
    arr = [5, 43, 2, 3, 4, -22, 4],
    len = arr.length;
for (i = 0; i < len; i += 1) {
    minIndex = i;
    for (j = i + 1; j < len; j += 1) {

        if (arr[minIndex] > arr[j]) {
            minIndex = j;
        }

    }
    comparedElement = arr[i];
    arr[i] = arr[minIndex];
    arr[minIndex] = comparedElement;
}
console.log(arr);
jsConsole.writeLine(arr);
jsConsole.writeLine('-----------------------------------------------------------------------------');