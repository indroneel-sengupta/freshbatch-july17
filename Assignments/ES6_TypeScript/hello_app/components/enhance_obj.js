export function  enhance_fun(){
  let order={
        id : "1",
        title : "es6",
        price : 3000,
        printOrder : function(){
            console.log(this.order);
        },
        getPrice : function(){
            return (this.price);
        }
  };
   let copyObj = Object.assign(order);
   console.log(copyObj);

    
}