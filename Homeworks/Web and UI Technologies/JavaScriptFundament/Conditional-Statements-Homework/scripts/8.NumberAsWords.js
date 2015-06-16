//Write a script that converts a number in the range [0…999] to wordOness, corresponding to its English pronunciation.
jsConsole.writeLine('Problem 8. Number as word');
var number = prompt('Please enter a number from 0 to 999: ') | 0;
var ones = number % 10;
var tens = (Math.floor(number / 10)) % 10;
var hundreds = (Math.floor(number / 100)) % 10;
var wordOnes = '';
var wordTens='';
var wordHundreds = '';
var numberAsWord = '';
var alertMesage = '';
if (number >= 0 && number <= 999) {
    if (ones !== 0) {
        switch (ones) {
            case 1: wordOnes = 'One'; break;
            case 2: wordOnes = 'Two'; break;
            case 3: wordOnes = 'Three'; break;
            case 4: wordOnes = 'Four'; break;
            case 5: wordOnes = 'Five'; break;
            case 6: wordOnes = 'Six'; break;
            case 7: wordOnes = 'Seven'; break;
            case 8: wordOnes = 'Eight'; break;
            case 9: wordOnes = 'Nine'; break;
            default: break;
        }
    }
    if (hundreds !== 0) {
        var wordHund;
        switch (hundreds) {
            case 1: wordHund = 'One'; break;
            case 2: wordHund = 'Two'; break;
            case 3: wordHund = 'Three'; break;
            case 4: wordHund = 'Four'; break;
            case 5: wordHund = 'Five'; break;
            case 6: wordHund = 'Six'; break;
            case 7: wordHund = 'Seven'; break;
            case 8: wordHund = 'Eight'; break;
            case 9: wordHund = 'Nine'; break;
            default: break;
        }
        if (tens !== 0 || ones !== 0) {
            wordHundreds = wordHund + ' Hundred and ';
        } else {
            wordHundreds = wordHund + ' Hundred';
        }
    }
    if (tens !== 0) {
        var wordTen;
        if (tens === 1) {
            tens = tens + ones;
            switch (tens) {
                case 10: wordTen = 'ten'; break;
                case 11: wordTen = 'eleven'; break;
                case 12: wordTen = 'twelve'; break;
                case 13: wordTen = 'thirteen'; break;
                case 14: wordTen = 'Four'; break;
                case 15: wordTen = 'fifteen'; break;
                case 5: wordTen = 'Five'; break;
                case 16: wordTen = 'Six'; break;
                case 17: wordTen = 'Seven'; break;
                case 18: wordTen = 'Eight'; break;
                case 19: wordTen = 'Nine'; break;
                default:; break;
            }
        } else {
            switch (tens) {
                case 2: wordTen = 'Twenty'; break;
                case 3: wordTen = 'Thirty'; break;
                case 4: wordTen = 'Fourteen'; break;
                case 5: wordTen = 'Fifty'; break;
                case 6: wordTen = 'Sixty'; break;
                case 7: wordTen = 'Seventy'; break;
                case 8: wordTen = 'Eighty'; break;
                case 9: wordTen = 'Ninety'; break;
                default: break;
            }
        }
        wordTens = wordTen + ' ';
    } else {
        if (ones !== 0)
            wordTens = ' and ';
    }
    numberAsWord = wordHundreds + ' ' + wordTens + ' ' + wordOnes;
} else {
    numberAsWord = 'Not a Number';
}

if (number === 0) {
    alertMesage = "Zero";
}
else {
    alertMesage = numberAsWord;
}
alert(alertMesage);
jsConsole.writeLine(alertMesage);
console.log(alertMesage);
jsConsole.writeLine('-----------------------------------------------------------------------------');
