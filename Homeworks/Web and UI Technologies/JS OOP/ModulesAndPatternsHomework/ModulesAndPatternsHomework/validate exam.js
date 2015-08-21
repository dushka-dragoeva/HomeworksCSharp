function isIdValid(number, min, max) {
    if (!(Number(number)) || number < 1 || number % 1 > 0) {
        throw new Error('ID must be an Integer');
    }

    number = +number;

    if (number < min || number >= max) {
        throw new Error('Invalid ID')
    }

}
function isValidScore(number) {
    if (!(Number(number)) || number < 1) {
        throw new Error('Invalid Score!');
    }
}

 function pushExamResults (results) {
    // [ {StudentID: ..., Score: ...}]

    results.forEach(function (item) {
        isIdValid(item[0]);
        isValidScore(item[1]);
        return results;
                
    });

}