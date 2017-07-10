
function displayNumber(){
	

	var firstNumber = prompt("Please enter 1st number", "0-9999");
	var secondNumber = prompt("Please enter 2nd number", "0-9999");
	

	if (secondNumber == 0) {
		
		alert("The second no. you entered is zero");
	}else{
		document.write("Division = ",(firstNumber/secondNumber));
	}
}