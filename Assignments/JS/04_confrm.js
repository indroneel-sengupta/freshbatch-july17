function displayTable(){
		var tableNumber = prompt("Please enter the number", "0-999");
		for(var i=1 ; i<=12 ; i++){
			var tab = i*tableNumber;	
			document.writeln(tableNumber,"*",(i),"= ",tab,"<br>");
		}
		document.writeln("<button id = 'butID'> Do you want to continue </button> <br>");
document.getElementById("butID").onclick = function() {continueTable()}
}
function continueTable(){
		if(confirm("Do you want to put another number to")){
			displayTable();
		}else{
				return;
		}	
}