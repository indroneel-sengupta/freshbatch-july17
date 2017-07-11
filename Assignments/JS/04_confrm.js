var temp=0;
function displayTable(){
		temp = temp+1;
		var tableNumber = prompt("Please enter the number", "0-999");
		for(var i=1 ; i<=12 ; i++){
			var tab = i*tableNumber;	
			document.writeln(tableNumber,"*",(i),"= ",tab,"<br>");
		//	var p=new Array($(element[i]).val());
		}
		document.writeln("<button id = 'butID"+temp+"'> Do you want to continue </button> <br>");
document.getElementById("butID"+temp).onclick = function() {continueTable()}
}
function continueTable(){
		if(confirm("Do you want to put another number to")){
			displayTable();
		}else{
				return;
		}	
}