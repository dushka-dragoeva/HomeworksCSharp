function solve() {

    function isNumber(num) {
        return !isNaN(parseFloat(num)) && isFinite(num);
    }

    function isString(literal) {
        if (typeof literal === 'string') {
            return true;
        } else {
            return false;
        }
    }

    function validateStudentName(name) {
        if (!isString(name)) {
            throw 'Student name must be string!';
        }

        if (!/^[A-Z][a-z]* [A-Z][a-z]*$/.exec(name)) {
            throw 'Please enter exactly in the format "Firstname Lastname"';
        }

        return true;
    }

    function validateTitle(title) {
        if (!isString(title)) {
            throw 'Student name must be string!';
        }

        if (/^ | $/.exec(title)) {
            throw 'Titles must not start or end with spaces!'
        }

        if (/ {2,}/.exec(title)) {
            throw 'Titles must not have consecutive spaces!'
        }

        if (!/.+/.exec(title)) {
            throw 'Titles must have at least one character!'
        }

        return true;
    }

    function validatePresentationTitles(presentationTitles) {
        if (!presentationTitles || !Array.isArray(presentationTitles) || presentationTitles.length === 0) {
            throw 'Invalid presentationTitles array!';
        }

        presentationTitles.forEach(function (title) {
            if (!validateTitle(title)) {
                throw 'Invalid presentation title at init()!';
            }
        });

        return true;
    }

    function validateStudentID(studentID) {
        if (!isNumber(studentID)) {
            throw 'Student ID must be number at submitHomework';
        }

        if (studentID <= 0 || studentID > this._lastStudentCourseID) {
            throw 'No such studentID';
        }

        return true;
    }

    function validateHomeworkID(homeworkID, studentID) {
        if (!isNumber(homeworkID)) {
            throw 'Homework ID must be number!';
        }

        if (homeworkID < 1 || homeworkID > this._presentationTitles.length) {
            throw 'Invalid homework ID. No such presentation!';
        }

        if (this._homeworks[studentID].some(
                function (currentHomeworkID) {
                    return currentHomeworkID === homeworkID;
        })) {
            throw 'Cannot submit a homework twice!';
        }

        return true;
    }

    function validateResults(results) {
        if (!isArray(results)) {
            throw 'Results must be an array!';
        }

        results.forEach(function (resultEntry, index, results) {
            validateStudentID.call(this, resultEntry.StudentID);
            if (results.indexOf(resultEntry) !== index) {
                throw 'No duplicate entries allowed in exam results!';
            }
        });
    }

    function calculateStudentsScore(studentsWithScore) {
        studentsWithScore.map(function (student) {
            var examScore = 0,
                homeworkScore = 0;

            this._results.some(
                function (resultEntry, index, results) {
                    if (resultEntry.StudentID === student.id) {
                        examScore = results[index];
                        return true;
                    }

                    return false;
                });
            homeworkScore = this._homeworks[student.id].length / this._presentationTitles.length;
            student.score = (examScore * .75) + (homeworkScore * .25);
        }, this);
    }

    function deepCopy(oldObject) {
        return JSON.parse(JSON.stringify(oldObject));
    }

    function sortByProperty(arr, prop) {
        return arr.sort(function (memberA, memberB) {
            if (memberA[prop] > memberB[prop]) {
                return 1;
            }

            if (memberA[prop] < memberB[prop]) {
                return -1;
            }

            if (memberA[prop] === memberB[prop]) {
                return 0;
            }
        });
    }
    var studentsScore = [];
    var Course = {
        init: function (title, presentationTitles) {
            validateTitle(title);
            validatePresentationTitles(presentationTitles);

            this._title = title;
            this._presentationTitles = presentationTitles;
            this._lastStudentCourseID = 0;
            this._homeworks = [null];
            this._students = [];
            return this;
        },
        addStudent: function (name) {
            validateStudentName(name);

            this._students.push({
                firstname: name.split(' ')[0],
                lastname: name.split(' ')[1],
                id: ++this._lastStudentCourseID
            });
            this._homeworks.push([]);
            return this._lastStudentCourseID;
        },
        getAllStudents: function () {
            return deepCopy(this._students);
        },
        submitHomework: function (studentID, homeworkID) {
            validateStudentID.call(this, studentID);
            validateHomeworkID.call(this, homeworkID, studentID);

            this._homeworks[studentID].push(homeworkID);
            return this;
        },
        pushExamResults: function (results) {
            validateResults(results);

            this._results = results;
        },
        getTopStudents: function () {
            var studentsWithScore = deepCopy(this._students);
            calculateStudentsScore(studentsWithScore);
            var topTen = studentsWithScore.sortByProperty(studentsWithScore, 'score').slice(0, 10);
            return topTen;
        }
    };

    return Course;
}

var test = solve();
var testCourse = test.init('Course title', ['p1', 'p2', 'p3']);
testCourse.addStudent('Ivan Ivanov');
testCourse.addStudent('Dvan Ivanov');
testCourse.addStudent('Gvan Ivanov');
testCourse.addStudent('Nvan Ivanov');
var results = [

]
console.log(testCourse.students);
console.log(testCourse.getAllStudents());
testCourse.submitHomework(3, 2);

//console.log(testCourse.students[3])
console.log(testCourse.getTopStudents);
console.log(testCourse.students.id);
