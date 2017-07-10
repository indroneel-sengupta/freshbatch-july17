function palin(){
	var str = prompt("Please enter any string", "malayalam");
	//var secondNumber = prompt("Please enter 2nd number", "0-9999");
	var i=0,len=str.length,flag=1;
		for(i=0 ; i<=(len/2) ; i++){
			if(str.charAt(i) != str.charAt(len-1)){
				flag = 0;
				break;
			}
			len--;
		}
		if(flag) document.writeln("pallindrome");
		else document.writeln("not pallindrome");
}