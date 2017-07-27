function numToArray(num){
    let arr=[];
    while(num>0){
        arr.push(parseInt(num%10));
        num = parseInt(num/10);
    }
    return arr;
}

function digitPow(digits){
    let sum=0;
    let length = digits.length;
    digits.forEach(function(d){
        sum+=Math.pow(d,length);
    });
    return sum;
}

function isArmstrong(num){
    let digitsPow = digitPow(numToArray(num));
    if(num===digitsPow) return true;
    return false;
}

export function* armstrongs(){
    let num = 1;
   while(true){
         try{
            if(num>1000){
                throw("next number is greater than 1000");
            }
         }catch(err){
            console.log("Error : ",err);
            break;
         }
         if(isArmstrong(num)){
            let reset = yield num;
            if(reset)   num=-1;
         }
        num++;
   }
}

export function armstrong2(){
     let arm = armstrongs();
    for(let i = 0 ; i<20 ; i++){
       
        console.log(arm.next().value);
    }
}
