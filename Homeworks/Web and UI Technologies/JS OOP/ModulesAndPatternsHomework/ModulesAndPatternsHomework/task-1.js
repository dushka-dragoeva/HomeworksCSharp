function solve() {

    (function () {
        if (!Array.prototype.indexOfPropertyValue) {
            Array.prototype.indexOfPropertyValue = function (prop, value) {
                for (var index = 0; index < this.length; index++) {
                    if (this[index][prop]) {
                        if (this[index][prop] === value) {
                            return index;
                        }
                    }
                }
                return -1;
            };
        }
    })();

    function isTitleValid(title) {
        if (title.length === 0 || (title !== title.trim()) || /\s{2,}/.test(title)) {
            throw new Error('Invalid Title');
        }
        return true;
    }

    function isPresentationsValid(value) {
        if (!(Array.isArray(value)) || !(value.length)) {
            throw new Error('Expected: a non-empty array');
        }
        value.forEach(function (item) {
            isTitleValid(item);
        });
        return true;
    }

    function isStudentNameValid(name) {
        var names;
        if (typeof name !== 'string') {
            return false;
        }

        names = name.split(' ');

        if (names.length !== 2) {
            return false;
        }

        names.forEach(function (item) {
            if (!(/^[A-Z][a-z]*$/.test(item))) {
                return false;
            }
            return false;
        });

        return names;
    }

    function isIdValid(number, min, max) {
        if (!(Number(number)) || number < 1 || number % 1 > 0) {
            throw new Error('ID must be an Integer');
        }

        number = +number;

        if (number < min || number > max) {
            throw new Error('Invalid ID');
        }

    }
    function isValidScore(number) {
        if (!(Number(number)) || number < 0) {
            throw new Error('Invalid Score!');
        }
    }
    function calculateFinalScore() {
        const EXAM_RESULT_QUOTA = 0.75;
        const SUBMETED_HOMEWORK_QUOTA = 0.25;
        var i,
           //submitted = this.students.submittedHomeworks.length,
           requiredHomeworks = this.presentations.length,
           submittedHomeworksScore,
           len = this.students.lenth;

        for (i=0; i<len;i+=1){
            submittedHomeworksScore = (this.students[i].submittedHomeworks.length/ requiredHomeworks) * SUBMETED_HOMEWORK_QUOTA;
            this.students[i].finalScore = this.students[i].examScore * EXAM_RESULT_QUOTA + submittedHomeworksScore;
        }
         
    }

    var Course = {

        init: function (title, presentations) {
            isTitleValid(title);
            this.title = title;
            isPresentationsValid(presentations);
            this.presentations = presentations;
            this.students = [];

            return this;
        },

        addStudent: function(name) {
            if (!isStudentNameValid(name)) {
                throw new Error('Invalid student name!');
            }
            var id = 0, names = [];
           names = isStudentNameValid(name);

            id = this.students.length + 1;
            this.students.push({
                firstname: names[0],
                lastname: names[1],
                id: id,
                submittedHomeworks: [],
                examScore: 0,
                finalScore: 0
            });

            return id;

        },
        getAllStudents: function () {
            return this.students.map(function (item) {
                return {
                    firstname: item.firstname,
                    lastname: item.lastname,
                    id: item.id
                };
            });
        },
        submitHomework: function (studentID, homeworkID) {
            var idIndex = 0;
            isIdValid(studentID, 1, this.students.length);
            isIdValid(homeworkID, 1, this.presentations.length);
          //  this.students[studentID - 1].submittedHomeworks.push(homeworkID);
            idIndex = this.students.indexOfPropertyValue('id', studentID);
           this.students[idIndex].submittedHomeworks.push(homeworkID);

        },
        pushExamResults: function (results) {
            var i,
                len = results.length,
                max = this.students.length;

            for (i = 0; i < len; i += 1) {

                isIdValid(results[i].StudentID, 1, max);
                isValidScore(results[i].Score);
                if (this.students[(results[i].StudentID) - 1].examScore!==0) {
                    throw new Error('Student is trying to cheat!');
                }
                this.students[(results[i].StudentID) - 1].examScore = results[i].Score;

            }

        },

        getTopStudents: function () {
            
            const EXAM_RESULT_QUOTA = 0.75;
            const SUBMETED_HOMEWORK_QUOTA = 0.25;

            var i,
               submitted,
               submittedHomeworksScore,
               requiredHomeworks = this.presentations.length,
               len = this.students.length;

            for (i = 0; i < len; i += 1) {
                submitted = this.students[i].submittedHomeworks.length;
                submittedHomeworksScore = (submitted/requiredHomeworks) * SUBMETED_HOMEWORK_QUOTA;
                this.students[i].finalScore = this.students[i].examScore * EXAM_RESULT_QUOTA + submittedHomeworksScore;
            }


            var sortedStudents = this.students.slice().sort(function (a, b) {
                return a.finalScore < b.finalScore;
            });

            return sortedStudents.slice(0,10);
        }

    };

    return Course;
}
var test = solve();
//var testCourse = test.init(' Course title ', [' p1 ', 'p2', 'p3']);
//testCourse.addStudent('Ivan Ivanov tttt');
//testCourse.addStudent('Dvan Ivanov');
//testCourse.addStudent('Gvan Ivanov');
//testCourse.addStudent('Nvan Ivanov');
//console.log(testCourse.students);
//console.log(testCourse.getAllStudents());
//console.log(testCourse.studentsResults);

//testCourse.submitHomework(2, 1);

//var results = [{ StudentID: 1, Score: 75 }, { StudentID: 2, Score: 100 }, { StudentID: 3, Score: 100 }, { StudentID: 4, Score: 96 }]
//testCourse.pushExamResults(results);
//console.log(testCourse.getTopStudents());
////console.log(testCourse.students[2].id);
//console.log(testCourse.students[2].examScore)

var c = test.init ('JS-OOP', [
    'Functions declarions , expressions and IIFEs',
    'Closures and Scope',
    'Classical Inheritance in JavaScript',
    'Prototype-based inheritance',
    'JavaScript Patterns',
    'Creating and Using Exceptions',
    'Object and Object.prototype methods',
    'ECMAScript 6 classes & inheritance'
]);

c.addStudent('Pesho Petrov');
c.addStudent('Tosho Marinov');
c.addStudent('Marin Zaplesa');
c.addStudent('Prostak Todorov');
c.addStudent('Traktorista Manolov');
c.addStudent('Dancho Prostaka');
c.addStudent('Muncho Tarikata');
c.addStudent('Petarcho Bastuna');
c.addStudent('Bastun Angelov');
c.addStudent('Gvan Ivanov');

c.submitHomework(1, 1);
c.submitHomework(1, 3);
c.submitHomework(1, 4);
c.submitHomework(1, 5);
c.submitHomework(1, 6);
c.submitHomework(1, 7);
c.submitHomework(1, 8);

c.submitHomework(2, 1);
c.submitHomework(2, 2);
c.submitHomework(2, 4);
c.submitHomework(2, 5);
c.submitHomework(2, 7);
c.submitHomework(2, 8);

c.submitHomework(3, 1);
c.submitHomework(3, 2);
c.submitHomework(3, 3);
c.submitHomework(3, 4);
c.submitHomework(3, 5);
c.submitHomework(3, 7);
c.submitHomework(3, 8);

c.submitHomework(4, 1);
c.submitHomework(4, 2);
c.submitHomework(4, 4);
c.submitHomework(4, 6);

c.submitHomework(5, 1);
c.submitHomework(5, 2);
c.submitHomework(5, 3);

c.submitHomework(6, 1);
c.submitHomework(6, 4);

c.submitHomework(7, 4);

c.submitHomework(8, 1);
c.submitHomework(8, 2);
c.submitHomework(8, 3);
c.submitHomework(8, 5);
c.submitHomework(8, 7);
c.submitHomework(8, 8);

c.submitHomework(9, 1);
c.submitHomework(9, 2);
c.submitHomework(9, 3);
c.submitHomework(9, 4);
c.submitHomework(9, 5);
c.submitHomework(9, 6);
c.submitHomework(9, 7);
c.submitHomework(9, 8);

c.submitHomework(10, 1);
c.submitHomework(10, 2);
c.submitHomework(10, 4);
c.submitHomework(10, 8);

c.pushExamResults([
    {
        StudentID: 5,
        Score: 3
    }, {
        StudentID: 1,
        Score: 5.25
    }, {
        StudentID: 2,
        Score: 5
    }, {
        StudentID: 7,
        Score: 2.50
    }, {
        StudentID: 10,
        Score: 3
    }, {
        StudentID: 4,
        Score: 3.75
    }, {
        StudentID: 9,
        Score: 5.80
    }, {
        StudentID: 3,
        Score: 6
    }, {
        StudentID: 6,
        Score: 3.25
    }
]);
console.log(c.getTopStudents());