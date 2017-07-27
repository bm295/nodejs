var yargs = require('yargs');

var get_argv = yargs.command('get', 'Get List Students', function (yargs) {
	return yargs.options({
		username: {
			demand: true,
			type: 'string',
			alias: 'u',
			default: 'bm295'
		},
		email: {
			demand: true
		}
	});
}).help().argv;

console.log(get_argv);