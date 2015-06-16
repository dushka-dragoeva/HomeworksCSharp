//Write a script that finds the most frequent number in an array. 
jsConsole.writeLine('Problem6. Most frequent number')

var i,
    mostFrequent=1,
    frequency=1,
    maxFrequency = 1,
    arr = [4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3],
    len = arr.length;
arr = arr.sort();

for (i = 0; i < len; i += 1) {

    if (arr[i] === arr[i + 1]) {
        frequency += 1;
    }
    else {

        if (frequency > maxFrequency) {
            maxFrequency = frequency;
            mostFrequent = arr[i];
            frequency = 1;
        }
        else frequency = 1;
    }
}
console.log(arr);
console.log( mostFrequent + ' (' + maxFrequency + ' times)' );
jsConsole.writeLine(mostFrequent + ' (' + maxFrequency + ' times)');
jsConsole.writeLine('-----------------------------------------------------------------------------');