
function checkVowel(){
	

	var al = prompt("Please enter any string", "my name");
	//var secondNumber = prompt("Please enter 2nd number", "0-9999");
	var flag = false;
	var alpha,len=al.length,cntA=0,cntE=0,cntI=0,cntO=0,cntU=0;  
	for(var i=0 ; i<len ; i++ ){
		alpha = al.charAt(i);
		switch(alpha){
			case 'a':
			case 'A':
				cntA++;
				break;
			case 'e':
			case 'E':
				cntE++;
				break;
			case 'i':
			case 'I':
				cntI++;
				break;	
			case 'o':
			case 'O':
				cntO++;
				break;
			
			case 'u':
			case 'U':
				cntU++;
				break;
		}
		
	}	
	document.writeln("a = "+cntA);
	document.writeln("e = "+cntE);
	document.writeln("i = "+cntI);
	document.writeln("o = "+cntO);
	document.writeln("u = "+cntU);
}