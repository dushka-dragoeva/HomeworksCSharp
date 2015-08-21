function solve() {
    var library = (function () {
        var books = [],
            categories = [];

        function listBooks(property) {
            var prop,
                sortedBooks = books.slice();
            if (property) {
                for (prop in property) {
                    if (property.hasOwnProperty(prop)) {
                        sortedBooks = sortedBooks.filter(function (item) {
                            return item[prop] === property[prop];
                        });
                    }
                }
            }

            return sortedBooks.sort(function (a, b) {
                a.id - b.id;
            });
        }

        function isNameValid(name) {
            if (name.length < 2 || name.length > 100) {
                throw new Error('Invalid length - it must be between 2 and 100 characters!');
            }
            return true;
        }

        function isAutherValid(author) {
            if (author.trim() === '') {
                throw new Error('Error - Auther cannot be empty string!');
            }
            return true;
        }

        function isIsbnValid(isbn) {
            if (isbn.length !== 10 || isbn.length !== 13 || (!/^[0-9]+$/.test(isbn.toString()))) {
                throw new Error('This ISBN is not valid! It must be 10 or 13-digit number!');
            }
            return true;
        }

        function isParameterUnique(name, type) {
            if (books[type].indexOf(name) >= 0) {
                throw new Error('This ' + type + ' already exist!');
            }
            return true;
        }

        function createCategory(name) {
            categories[name] = {
                books: [],
                ID: categories.length + 1
            };
        }

        function checkUniqueISBN(tempISBN) {
            var i, len;
            if (tempISBN.length != 10 && tempISBN.length != 13) {
                return true;
            }

            for (i = 0, len = books.length; i < len; i += 1) {
                if (books[i].isbn === tempISBN) {
                    return true;
                }
            }
            return false;
        }

        function checkTitleAndCategory(title) {
            var i, len;
            if (!(title.length > 2 && title.length < 101)) {
                return true;
            }
            for (i = 0, len = books.length; i < len; i += 1) {
                if (books[i].title === title) {
                    return true;
                }
            }
            return false;
        }
        function addBook(book) {

            function isBookValid() {

                if (
                    isNameValid(book.title) &&
                    isNameValid(book.category) &&
                    isValidIsbn(book.isbn)) {
                    return true;
                }
            }
         
            var tempISBN = book.isbn;
            if (checkUniqueISBN(tempISBN)) {
                throw new Error('Expected unique ISBN!');
            }
            
            if (checkTitleAndCategory(book.title)) {
                throw new Error('Expected unique title!');
            }
            if (!(book.author.length > 0)) {
                throw new Error('Expected author name!');
            }
            if (isBookValid) {
                book.ID = books.length + 1;
            }

            if (!(categories.indexOf(book.category) > -1)) {
                if (!checkTitleAndCategory(book.category)) {
                    var category = book.category;
                    category.ID = categories.length + 1;
                    categories.push(category);
                }
            }

            books.push(book);

            return book;
        }

        function listCategories() {
            
            return categories;
        }

        return {
            books: {
                list: listBooks,
                add: addBook
            },
            categories: {
                list: listCategories
            }
        };
    }());
    return library;
}