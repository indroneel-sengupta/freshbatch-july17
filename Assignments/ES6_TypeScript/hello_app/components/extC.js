export function  extC_fun(){

    function printCap(n1,n2,n3,n4,n5) {
        let str = n1+" "+n2+" "+n3+" "+n4+" "+n5
        let name = str.toUpperCase();
       
        console.log(name);
    }
    let a = ['neel', 'tom', 'jerry'];
    let b = ['rahul', ...a, 'sunny'];
    printCap(b);
    //console.log(userfrnds('Indroneel','Neel','Jason','jerry'));
}