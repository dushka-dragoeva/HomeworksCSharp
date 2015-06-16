//Write a script that finds the lexicographically smallest and largest property in document, window and navigator objects.
jsConsole.writeLine('Problem 4. Lexicographically smallest')

var property,
    minProperty = 'zzz',
    maxProperty = '';

for (property in document) {
    if (property < minProperty) {
        minProperty = property;
    }
    if (property > maxProperty) {
        maxProperty = property;
    }
}
console.log('smalest properti in document is ' + minProperty);
jsConsole.writeLine('smalest properti in document is ' + minProperty);
console.log('largest properti in document is ' + maxProperty);
jsConsole.writeLine('largest properti in document is ' + maxProperty);

minProperty = 'zzz';
maxProperty = '';
for (property in window) {
    if (property < minProperty) {
        minProperty = property;
    }
    if (property > maxProperty) {
        maxProperty = property;
    }
}
console.log('smalest properti in window is ' + minProperty);
jsConsole.writeLine('smalest properti in window is ' + minProperty);
console.log('largest properti in window is ' + maxProperty);
jsConsole.writeLine('largest properti in window is ' + maxProperty);

minProperty = 'zzz';
maxProperty = '';
for (property in navigator) {
    if (property < minProperty) {
        minProperty = property;
    }
    if (property > maxProperty) {
        maxProperty = property;
    }
}
console.log('smalest properti in navigator is ' + minProperty);
jsConsole.writeLine('smalest properti in navigator is ' + minProperty);
console.log('largest properti in navigator is ' + maxProperty);
jsConsole.writeLine('largest properti in navigator is ' + maxProperty);




