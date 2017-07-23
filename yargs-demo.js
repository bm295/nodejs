function isPrime(n) {
	var flag = true;

	if (n < 2) {
		flag = false;
	}
	else if (n == 2) {
		flag = true;
	}
	else if (n % 2 == 0) {
		flag = false;
	}
	else {
		for (var i = 3; i < n - 1; i+=2) {
			if (n % i == 0) {
				flag = false;
				break;
			}
		}
	}
	return flag;
}

var yargs = require('yargs');

var argv = yargs.argv;

if (typeof argv.n == "undefined") {
	console.log("Please input an integer");
}
else {
	if (isPrime(argv.n)) {
		console.log("This is prime number");
	}
	else {
		console.log("This is not prime number");
	}
}