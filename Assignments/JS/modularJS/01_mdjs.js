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