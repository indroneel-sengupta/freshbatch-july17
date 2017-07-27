class Account{
    anum:number;
    aname:string;
    abal:number;

    constructor(anum:number , aname:string , abal:number){
        this.anum = anum;
        this.aname  = aname;
        this.abal = abal;
    }

    getBal():number{
        return (this.abal);
    }
}

class SavingsAccount extends Account{
    aint:number;
    constructor(anum:number , aname:string , abal:number , aint:number){
            super(anum,aname,abal);
            this.aint = aint;
    }
    getBal():number{
        return (super.getBal() + this.aint);
    }

}

class CurrentAccount extends Account{
    acash:number;
    constructor(anum:number , aname:string , abal:number , acash:number){
            super(anum,aname,abal);
            this.acash = acash;
    }
    getBal():number{
        return (super.getBal() + this.acash);
    }

}

function getCashOfBank():void{
    let account = [212,214,236,547,564];
            var totAcntCash = 0;
            let savAcnt;
            let curAcnt;
           for(let i in account){ 
                savAcnt = new SavingsAccount(account[i],'raj',(i*100),(i/100));
                curAcnt = new CurrentAccount(account[i],"raj",(i*10),(i/10));
                totAcntCash = totAcntCash + (savAcnt.getBal() + curAcnt.getBal())
            }
            console.log(totAcntCash);
}

getCashOfBank();