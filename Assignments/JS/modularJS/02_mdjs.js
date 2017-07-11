function Employee(eid,ename,esal){
	this.eid = eid;
	this.ename = ename;
	this.esal = esal;
}
function EmployeeList(ary){
	
	//this.ary  = ary;
	console.log(ary.length);
		return {
					arrSort : function() {
					/*	var i=0,j=0,len = ary.length;
						console.log(len);
						var temp = new Employee();
						for(i=0 ; i<len ; i++){
							for(j=i+1 ; j<len ; j++){
								if(ary[j].eid < ary[i].eid){
									temp = ary[j];
									ary[j] = ary[i];
									ary[i] = temp;
								}
							}
						}*///both the ways for sorting are working
						ary.sort(function(a, b){return a.eid - b.eid});
						
						
					},
					
					display : function() {
						
						console.log(ary);
					}
			
			
		}
	
	
		
	    

		//document.getElementById("div1").innerHTML = "The Sorted employee list is "+ary;
	}


function test(){
	var emp = new Array();
		emp[0] = new Employee(3,"Rajesh",10030);
		emp[1] = new Employee(31,"Rajesh",10200);
		emp[2] = new Employee(2,"Rajesh",10090);
		emp[3] = new Employee(23,"Rajesh",10100);
		emp[4] = new Employee(12,"Rajesh",10400);
		emp[5] = new Employee(99,"Rajesh",10500);
		emp[6] = new Employee(14,"Rajesh",10400);
		emp[7] = new Employee(36,"Rajesh",10600);
		emp[8] = new Employee(32,"Rajesh",10400);
		emp[9] = new Employee(59,"Rajesh",10100);
	var empList = new EmployeeList(emp);
	empList.arrSort();
	empList.display();
}