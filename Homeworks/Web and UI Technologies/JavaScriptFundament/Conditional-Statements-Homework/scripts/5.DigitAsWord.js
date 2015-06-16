
//Write a script that asks for a digit (0-9), and depending on the input, shows the digit as word (in English).
//Print “not a digit” in case of invalid input.Use a switch statement.

jsConsole.writeLine('Problem 5. Digit as word');
var digit = prompt('Please enter a digit 0-9 : ') | 0;
var alertMesage = '';
switch (digit){
    case 1: alertMesage = 'One'; break;
    case 2: alertMesage = 'Two'; break;
    case 3: alertMesage = 'Three'; break;
    case 4: alertMesage = 'Four'; break;
    case 5: alertMesage = 'Five'; break;
    case 6: alertMesage = 'Six'; break;
    case 7: alertMesage = 'Seven'; break;
    case 8: alertMesage = 'Eight'; break;
    case 9: alertMesage = 'Nine'; break;
    case 0: alertMesage ='zero'; break;
    default: alert('not a digit'); break;
}
alert(alertMesage);
jsConsole.writeLine(alertMesage);
console.log(alertMesage);

jsConsole.writeLine('-----------------------------------------------------------------------------');
