var login_attempts=3;

function login(){
	var userID = "neel";
	var passwrd = "1234"; 
	var cnt=0;

	if((document.getElementById("uid").value == userID)  && (document.getElementById("pw").value == passwrd)){
		document.writeln("authenticated User");
		document.getElementById("uid").value="";
		document.getElementById("pw").value="";
	}else{
		
			login_attempts=login_attempts-1;
			alert("Login Failed Now Only "+login_attempts+" Login Attempts Available");
			if(login_attempts==0){
				alert("You have exceeded the limit now you cannot login");
				document.getElementById("uid").disabled=true;
				document.getElementById("pw").disabled=true;
				document.getElementById("form1").disabled=true;
			}
		

	}
	
	
	
}