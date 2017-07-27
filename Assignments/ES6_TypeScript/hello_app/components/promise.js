
export function promise(){
    var p1 = Promise.resolve(5);
    var p2 = Promise.resolve(9);
    Promise.all([p1,p2]).then(function(promises){
        let sum = promises[0]+promises[1];
        // promises.forEach(function(num) {

            console.log(sum);

        // });
    });
}