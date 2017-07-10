
var arr = new Array();
			
function addElem(){
	var temp = parseInt(document.getElementById('newElement').value);
	arr.push(temp);
	document.getElementById('newElement').value = "";
}
function maxMinAvg() {
    var max = arr[0];
    var min = arr[0];
    var sum = arr[0];
    for (var i = 1; i < arr.length; i++) {
        if (arr[i] > max) {
            max = arr[i];
        }
        if (arr[i] < min) {
            min = arr[i];
        }
        sum = sum + arr[i];
    }
    var avg = sum / arr.length;
    document.writeln("total = "+sum+"<br>"+"min = "+min+"<br>"+"max = "+max+"<br>"+"avg = "+avg);
}