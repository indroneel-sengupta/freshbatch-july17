
var ary = new Array();
			
function addElem(){
	var temp = parseInt(document.getElementById('newElement').value);
	ary.push(temp);
	document.getElementById('newElement').value = "";
}
function ascending() {
    var i=0,j=0,temp=0;
	for(i=0 ; i<ary.length ; i++){
		for(j=i+1 ; j<ary.length ; j++){
			if(ary[j] < ary[i]){
				temp = ary[j];
				ary[j] = ary[i];
				ary[i] = temp;
			}
		}
	}
	
	//for(i=0 ; i<ary.length ; i++){
		document.getElementById('demo').innerHTML ="Ascending Sort"+ "<br>"+ary;
	//}
}

function descending() {
    var i=0,j=0,temp=0;
	for(i=0 ; i<ary.length ; i++){
		for(j=i+1 ; j<ary.length ; j++){
			if(ary[j] > ary[i]){
				temp = ary[j];
				ary[j] = ary[i];
				ary[i] = temp;
			}
		}
	}
	//for(i=0 ; i<ary.length ; i++){
		document.getElementById("demo1").innerHTML ="Descending Sort"+ "<br>"+ary;
	//}
}