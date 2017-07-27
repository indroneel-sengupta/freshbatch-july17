interface Printable{
    printStr:string;
    print:()=>void
}

let circle: Printable = {
     printStr: "Indroneel Typescript", 
     print:()=>console.log("Circle printed ", circle.printStr) 
}

let employee: Printable = {
     printStr: "Indroneel employee", 
     print:()=>console.log("Employee printed ", employee.printStr) 
}

let arr: Array<Printable> = [circle,employee]
function printAll(myPrintables: Array<Printable>):void{
    myPrintables.forEach(function(obj){
       obj.print(); 
    })
}

printAll(arr);