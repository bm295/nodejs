var storage = require('node-persist');

storage.initSync({
	dir: "students"
});

function getAllStudents() {
	var students = storage.getItemSync('students');
	if (typeof students == "undefined") {
		return [];
	}
	return students;
}

function getStudent(studentId) {
	var students = getAllStudents();
	var matchedStudent = null;
	for (var i = 0; i < students.length; i++) {
		if (students[i].Id === studentId) {
			matchedStudent = students[i];
			break;
		}
	}
	return matchedStudent;
}

function addStudent(id, fullName) {
	var students = getAllStudents();
	students.push({
		Id : id,
		FullName : fullName
	});
	storage.setItemSync('students', students);
}

function removeStudent(studentId) {
	var students = getAllStudents();
	for (var i = 0; i < students.length; i++) {
		if (students[i].Id === studentId) {
			students.splice(i, 1);
		}
	}
	storage.setItemSync('students', students);
}

function editStudent(studentId, studentName) {
	var students = getAllStudents();
	for (var i = 0; i < students.length; i++) {
		if (students[i].Id === studentId) {
			students[i].FullName = studentName;
		}
	}
	storage.setItemSync('students', students);
}

function showStudents() {
	var students = getAllStudents();
	students.forEach(function(student) {
		console.log('Student: ' + student.FullName + ' (' + student.Id + ')');
	});
	console.log();
}

storage.setItemSync('students', []);

addStudent(1, "A");
addStudent(2, "B");
addStudent(3, "C");
addStudent(4, "D");
addStudent(5, "E");
showStudents();

removeStudent(5);
showStudents();

editStudent(4, "E");
showStudents();