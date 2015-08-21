/* Task description */
/*
	Write a function that finds all the prime numbers in a range
		1) it should return the prime numbers in an array
		2) it must throw an Error if any on the range params is not convertible to `Number`
		3) it must throw an Error if any of the range params is missing
*/
function solve() {
   return function findPrimes(startNumber, endNumber) {
        var divisor,
            maxDiviser,
            n,
            isPrime =true,
            primes = [];
        if (typeof (startNumber) === undefined || typeof (endNumber) === undefined) {
            throw new Error();
        }
        if (arguments.length < 2) {
            throw new Error();
        }
        startNumber = +startNumber;
        endNumber = +endNumber;
        if (isNaN(startNumber) || isNaN(endNumber)) {
            throw new Error();
        }
        for (n = startNumber; n <= endNumber; n += 1) {
            maxDiviser = Math.abs(n);
            maxDiviser = Math.sqrt(maxDiviser);
            for (divisor = 2; divisor <= maxDiviser; divisor += 1) {
                isPrime = true;
                if (n % divisor === 0) {
                    isPrime = false;
                    break;
                }

            }
            if (isPrime && n > 1) {
                primes.push(n);
            }
        }

        return primes;
    }
   // console.log (findPrimes(3,15));
}

//module.exports = findPrimes;
