var circle = {
    printStr: "Indroneel Typescript",
    print: function () { return console.log("Circle printed ", circle.printStr); }
};
var employee = {
    printStr: "Indroneel employee",
    print: function () { return console.log("Employee printed ", employee.printStr); }
};
var arr = [circle, employee];
function printAll(myPrintables) {
    myPrintables.forEach(function (obj) {
        obj.print();
    });
}
printAll(arr);
