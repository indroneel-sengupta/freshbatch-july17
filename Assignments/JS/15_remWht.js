function rmSpace(){
		var s = prompt("Please enter any string", "");
		s.replace(/\s+/g, " ").replace(/^\s|\s$/g, "");
		document.writeln(s);

}