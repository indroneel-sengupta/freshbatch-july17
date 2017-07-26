    let prv = Symbol();
    let cur = Symbol(); 
    class Fibonacci {
       constructor(prev,curr){
            this[prv] = prev;
            this[cur] = curr;
       }
       
        next() {
            [this[prv], this[cur]] = [this[cur],this[prv] +this[cur]];
            return {done: false, value: this[cur]};
        }
    }
        
    

    export function  itt_fun(){
        let obj = new Fibonacci(0,1);
        console.log("Fibonacci no ", obj.next()); //call itr.next() multiple times…
        console.log("Fibonacci no ", obj.next());
        console.log("Fibonacci no ", obj.next());
        console.log("Fibonacci no ", obj.next());
        console.log("Fibonacci no ", obj.next());
        
        
    }