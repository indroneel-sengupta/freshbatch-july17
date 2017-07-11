var bankAccount = {
	accNo : "327456",
	accBal : "10000",
	accName : "xyz",
	amt : "1000",
	withdraw : function(amt){
		accBal = parseInt(bankAccount.accBal) - parseInt(bankAccount.amt);
		document.writeln("Your current balance is "+accBal);
	},
	deposit : function(amt){
		accBal = parseInt(bankAccount.accBal) + parseInt(bankAccount.amt);
		document.writeln("balance for "+bankAccount.accName+" is "+accBal);
	}
};

function Keg(accNo,accBal,accName){
	this.accNo = accNo;
	this.accBal = accBal;
	this.accName = accName;
	this.withdraw = function(amt){
		accBal = parseInt(accBal) - parseInt(amt);
		document.writeln("balance for "+accName+" is "+accBal);
	};
	this.deposit = function(amt){
		accBal = parseInt(accBal) + parseInt(amt);
		document.writeln("balance for "+accName+" is "+accBal);
	};
}
function test2(){
	var keg = new Keg("99999","10965","Indroneel");
	keg.withdraw("965");
	keg.deposit("35");
}

var Keg = {
	accBal:"unknown",
	accNo : "00000",
	accName : "No name",
	withdraw : function(amt){
		accBal = parseInt(this.accBal) - parseInt(amt);
		document.writeln("balance for "+this.accName+" is "+accBal);
	},
	deposit : function(amt){
		accBal = parseInt(this.accBal) + parseInt(amt);
		document.writeln("balance for "+this.accName+" is "+accBal);
	}
}
function test3(){
	var keg = Object.create(Keg);
	keg.accBal = "1012365";
	keg.accNo = "99999";
	keg.accName = "Indroneel"
	keg.deposit(35);
	keg.withdraw(35);
}

function Keg1(accno,accbal,accname) {
/* ... private members ... */
	var accNo = accno;
	var accBal = accbal;
	var accName = accname;
	var obj = {
		fill: function(acnum,acbal,acname) { 
			accNo = acnum;
			accBal = acbal;
			accName = acname;
		},
		withdraw: function(amt) {
			accBal = parseInt(accBal) - parseInt(amt);
			document.writeln("balance for "+accName+" is "+accBal+"</br>");
	
		},
		deposit: function(amt) {
			accBal = parseInt(accBal) + parseInt(amt);
			document.writeln("balance for "+accName+" is "+accBal+"</br>");
		}
	}
	return obj;
}
function test4(){
	var keg = new Keg1("99999", "11111","Test4");
	keg.withdraw(102); // 100.0
	keg.deposit(102);
	
}

function Keg2(accNo,accBal,accName){
	this.accNo = accNo;
	this.accBal = accBal;
	this.accName = accName;
}

Keg2.prototype.withdraw = function(amt){
	accBal = parseInt(this.accBal) - parseInt(amt);
	document.writeln("balance for "+this.accName+" is "+accBal+"<br>");

};

Keg2.prototype.deposit = function(amt){
	accBal = parseInt(this.accBal) + parseInt(amt);
	document.writeln("balance for "+this.accName+" is "+accBal+"<br>");

};

function test5(){
	var keg = new Keg2("55555","33333","Test 5");
	keg.withdraw(201);
	keg.deposit(101);
}
