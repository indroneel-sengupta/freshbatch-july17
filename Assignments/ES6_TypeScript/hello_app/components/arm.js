    let prv = Symbol();
    let cur = Symbol(); 
    class Arm {
       constructor(curr){
            
            this[cur] = curr;
       }

       isArm(){
           
       }
       
        next() {
            let sum=0;
            let ori=this[cur];
            for(let i = 0 ; i<3 ; i++){
                    console.log(sum,this[cur]%10);
                    [sum, ori] = [sum+(ori%10)*(ori%10)*(ori%10), parseInt(ori/10)];
                    
            }
            if(sum == this[cur]){
                    return {done: false, value: this[cur]};
            }else{
                return {done:false, value: null}
            }
            
        }
    }
        
    

    export function arm_fun(){
        let obj = new Arm(153);
        console.log("armstrong no ", obj.next()); //call itr.next() multiple times…
         console.log("armstrong no ", obj.next());
          console.log("armstrong no ", obj.next());
        
    }