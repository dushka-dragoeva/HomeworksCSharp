function solve() {
    function validateTitle(title) {
        if (!title.length) {
            throw new Error('Title must have at least one character! value: ' + title);
        }

        if (invalidTitlesRegEx.test(title)) {
            throw new Error('Title must not begin or end with a space or contain consecutive spaces! value: ' + title);
        }
    }

    function validateStudentName(name) {
        if (name.constructor !== String) {
            throw new TypeError('Student name must be a string! type: ' + typeof name);
        }

        if (!studentNameRegEx.test(name)) {
            throw new Error('Invalid student name! It must be a string in the format "Firstname Lastname". value: ' + name);
        }
    }

    function validateStudentID(studentID) {
        validateIDInCollection.call(this, studentID, 'students', 'Invalid studentID!');
    }

    function validateHomeworkID(homeworkID) {
        validateIDInCollection.call(this, homeworkID, 'presentations', 'Invalid homeworkID!');
    }

    function validateIDInCollection(id, collection, errorMessage) {
        var idExists = this[collection].some(function (item) {
            return item.id == id;
        });

        if (!idExists) {
            throw new Error(errorMessage + ' value: ' + id);
        }
    }

    function getStudentByID(studentID) {
        var studentIndex = this.students.map(function (student) {
            return student.id;
        }).indexOf(studentID);

        if (studentIndex === -1) {
            throw new Error('Student with ID: ' + studentID + ' was not found');
        } else {
            return this.students[studentIndex];
        }
    }

    function validateExamScore(Score) {
        if (Score.constructor !== Number) {
            throw new TypeError('Score must be a number! type: ' + typeof Score);
        }
    }

    function validateStudentIDsAreNotDuplicatedInExamResults(results) {
        var i,
            j,
            len;

        for (i = 0, len = results.length; i < len - 1; i += 1) {
            for (j = i + 1; j < len; j += 1) {
                if (results[i].StudentID == results[j].StudentID) {
                    throw new Error('StudentID: ' + results[i].StudentID + ' is duplicated at positions ' + i + ' and ' + j);
                }
            }
        }
    }

    var studentNameRegEx = /^([A-Z][a-z]*) ([A-Z][a-z]*)$/,
        invalidTitlesRegEx = /^\s|\s{2}|\s$/,

        examWeight = 0.75,
        homeworkWeight = 1 - examWeight,

        Course = {
            init: function (title, presentations) {
                this.title = title;
                this.presentations = presentations;
                this.students = [];

                return this;
            },

            addStudent: function (name) {
                var firstAndLastName,
                    firstName,
                    lastName,
                    id;

                validateStudentName(name);

                firstAndLastName = name.match(studentNameRegEx);
                firstName = firstAndLastName[1];
                lastName = firstAndLastName[2];

                id = this.students.length + 1;

                this.students.push({
                    firstname: firstName,
                    lastname: lastName,
                    id: id,
                    submittedHomework: Object.create(null),
                    examScore: 0,
                    finalScore: 0
                });

                return id;
            },

            getAllStudents: function () {
                return this.students.map(function (student) {
                    return {
                        firstname: student.firstname,
                        lastname: student.lastname,
                        id: student.id
                    }
                });
            },

            submitHomework: function (studentID, homeworkID) {
                var student;

                validateStudentID.call(this, studentID);
                validateHomeworkID.call(this, homeworkID);

                student = getStudentByID.call(this, studentID);
                student.submittedHomework[homeworkID] = true;
            },

            pushExamResults: function (results) {
                results.forEach(function (result) {
                    validateStudentID.call(this, result.StudentID);
                    validateExamScore(result.Score);
                }, this);

                validateStudentIDsAreNotDuplicatedInExamResults(results);

                results.forEach(function (result) {
                    var student = getStudentByID.call(this, result.StudentID);

                    student.examScore = result.Score;
                }, this);
            },

            getTopStudents: function () {
                var i,
                    topTenStudents = [],
                    presentationsCount = this.presentations.length,
                    studentsCount = this.students.length,
                    studentsUpToTenCount = (studentsCount > 10 ? 10 : studentsCount);

                // Calculate final score for each student.
                this.students.forEach(function (student) {
                    var submittedHomeworksCount = Object.keys(student.submittedHomework).length;

                    student.finalScore =
                        ((homeworkWeight * submittedHomeworksCount) / presentationsCount) + (student.examScore * examWeight);
                });

                this.students.sort(function (firstStudent, secondStudent) {
                    return secondStudent.finalScore - firstStudent.finalScore;
                });

                for (i = 0; i < studentsUpToTenCount; i += 1) {
                    topTenStudents.push({
                        firstname: this.students[i].firstname,
                        lastname: this.students[i].lastname,
                        id: this.students[i].id
                    });
                }

                return topTenStudents;
            }
        };

    Object.defineProperties(Course, {
        title: {
            set: function (title) {
                validateTitle(title);
                this._title = title;
            },

            get: function () {
                return this._title;
            }
        },
        presentations: {
            set: function (presentations) {
                if (presentations.constructor !== Array || !presentations.length) {
                    throw new Error('Presentations must be an non empty array.');
                }

                presentations.forEach(validateTitle);

                this._presentations = presentations.map(function (presentation, index) {
                    return {
                        title: presentation,
                        id: index + 1
                    }
                });
            },

            get: function () {
                return this._presentations;
            }
        }
    });

    return Course;
}
var test = solve();
var testCourse = test.init('Course title', ['p1', 'p2', 'p3']);
testCourse.addStudent('Ivan Ivanov');
testCourse.addStudent('Dvan Ivanov');
testCourse.addStudent('Gvan Ivanov');
testCourse.addStudent('Nvan Ivanov');
console.log(testCourse.students);
console.log(testCourse.getAllStudents());
console.log(testCourse.studentsResults);

testCourse.submitHomework(2, 1);

var results = [{ StudentID: 1, Score: 75 }, { StudentID: 2, Score: 100 }, { StudentID: 3, Score: 100 }, { StudentID: 4, Score: 96 }]
