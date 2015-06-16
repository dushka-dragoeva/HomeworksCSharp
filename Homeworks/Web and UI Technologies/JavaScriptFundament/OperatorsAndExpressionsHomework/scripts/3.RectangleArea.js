//Proplem 3 - Write an expression that calculates rectangle’s area by given width and height.//
jsConsole.writeLine('Problem 3. Rectangle area');
var width = [3, 2.5, 5],
    height = [4, 3, 3],
    area,
    len = width.length,
    i;
for ( i = 0; i < len; i++ ) {
    area= width[i] * height[i];
    jsConsole.writeLine('width: ' + width[i] + ' height:  ' + height[i] + ' area:  ' + area);
    console.log('width= ' + width[i] + ' height=  ' + height[i] + ' area= ' + area);
}
jsConsole.writeLine('-----------------------------------------------------------------------------');