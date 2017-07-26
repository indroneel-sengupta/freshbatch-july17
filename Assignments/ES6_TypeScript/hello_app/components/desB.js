export function  desB_fun(){
    let cust= {
        name: "Microsoft Corp.",
        address: {
        street: "J. M. Road",
        city: "Pune",
        state: "Maharashtra",
        zip: "411002"
    } };
let {address: {city, state}} = cust; //Deep matching
console.log("City:", city, "State:", state);
}