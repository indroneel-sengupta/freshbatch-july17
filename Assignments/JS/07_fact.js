function fact(){
	

	var firstNumber = prompt("Please enter starting of the range", "0-9999");
	var fn = parseInt(firstNumber);
	var i=0, fac =1;
	for(i=1 ; i<=fn ; i++ ){
		fac *= i;
	}
	document.writeln("Factorial of "+fn+" = "+fac);
	
}