
function checkVowel(){
	

	var alpha = prompt("Please enter any alphabet", "a-z");
	//var secondNumber = prompt("Please enter 2nd number", "0-9999");
	var flag = false;

	
		switch(alpha){
			case 'a':
			case 'e':
			case 'i':
			case 'o':
			case 'u':
			case 'A':
			case 'E':
			case 'I':
			case 'O':
			case 'U':
				flag = true;
				break;
		}
		if(flag){
			document.writeln(alpha + "= " + "vowel");
		}else{
			document.writeln(alpha + "= " + "Not vowel");
		}
}