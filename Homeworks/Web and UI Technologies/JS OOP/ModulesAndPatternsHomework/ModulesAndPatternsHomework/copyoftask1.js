function solve() {

    function isTitleValid(title) {
        if (title.length === 0 || (title !== title.trim()) || /\s{2,}/.test(title)) {
            return false;
        }
        return true;
    }

    function isPresentationsValid(value) {
        if (!(Array.isArray(value)) || !(value.length)) {
            throw new Error('Expected: a non-empty array')
        }
        forEach(function (item, i, arr) {
            if (!isTitleValid(item)) {
                throw new Error('Invalid Presentation Title')
            }
        });
        return true;
    }
    //function isTitleValid(title) {
    //    if(){
    //        return false;
    //    }
    //return true;
    //}



    var Course = {

        init: function (title, presentations) {


            this.title = title;
            this.presentations = presentations;
            return this;
        },
        //get title() {
        //    return this._title;
        //},
        //set title(value) {
        //    if (!isTitleValid(value)) {
        //        throw new Error ('Invalid Title')
        //    }
        //    this._title = value;
        //},

        //get presentations(){
        //    return this._presentations;
        //},
        //set presentation(value) {

        //    if(!(Array.isArray(value))||!(value.length)) {
        //        throw new Error('Expected: a non-empty array')
        //    }

        //    value.forEach(function (item) {
        //        if (!isTitleValid(item)) {
        //            throw new Error('Invalid Presentation Title')
        //        }
        //        //return value; ?  to check 
        //    });

        //    this._presentations = value;
        //},

        addStudent: function (name) {
        },
        getAllStudents: function () {
        },
        submitHomework: function (studentID, homeworkID) {
        },
        pushExamResults: function (results) {
        },
        getTopStudents: function () {
        }
    };

    return Course;
}


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

pushExamResults: function (results) {
    // [ {StudentID: ..., Score: ...}]

    results.forEach(function (item) {
        isIdValid(item[0]);
        isValidScore(item[1]);
        return results;
                
    });

}