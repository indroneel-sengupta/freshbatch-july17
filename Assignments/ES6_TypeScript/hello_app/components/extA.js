export function  extA_fun(){
    function add(a, b) {
        return a + b;
    }
    let nums= [5, 4];
    console.log("extended function A = ",add(...nums));
}