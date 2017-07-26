export function  arrow_fun(){
    let names = ['Tom', 'Ivan', 'Jerry'];
    var nameObj=[];
     names.map(
         (n) =>{
         let obj={name:n,length:n.length};
        nameObj.push(obj);
         }
    );
     console.log(nameObj);
}