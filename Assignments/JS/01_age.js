
function ageFinder(){
	var d = new Date();
	var todayYear = d.getFullYear();
	/*var todayMonth = d.getMonth();
	var todayDate = d.getDate();*/

	var person = prompt("Please enter your age", "99");

	if (person != null) {
		var age = todayYear - person;
		document.write("Birth year is ",age);
	}
}