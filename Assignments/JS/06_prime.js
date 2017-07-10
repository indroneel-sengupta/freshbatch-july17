function prime(){
	

	var firstNumber = prompt("Please enter starting of the range", "0-9999");
	var fn = parseInt(firstNumber);
	
	var secondNumber = prompt("Please enter ending of the range", "0-9999");
	var ln = parseInt(secondNumber);
	
	var i,flag,cnt=0;
	for(var pr = fn ; pr<=ln ; pr++){
		i=2;
		flag=1;
		while(i<pr){
			if(pr%i == 0) flag=0;
			i++;
		}
		if(flag == 1) cnt++; 
	}
	document.writeln(" The no of prime no between the given range is "+cnt);
	
}