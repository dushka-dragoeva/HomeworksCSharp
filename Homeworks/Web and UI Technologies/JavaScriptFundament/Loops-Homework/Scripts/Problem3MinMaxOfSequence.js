//Write a script that finds the max and min number from a sequence of numbers.
jsConsole.writeLine('Problem 3. Min/Max of sequence');
var numbers = [45, 77, 33, -5, -0.1, 987]
minNum = Number.MAX_VALUE,
maxNum = Number.MIN_VALUE;
var num;

for(num of numbers){
    if (num<minNum){
    minNum=num;
    }
    if(num>maxNum){
    maxNum=num;
    }
}
console.log('Min number is '+minNum);
jsConsole.writeLine('Min number is '+minNum);
console.log('Max number is '+maxNum);
jsConsole.writeLine('Max number is '+maxNum);
jsConsole.writeLine('-----------------------------------------------------------------------------');
