  
    
    class Account{
            constructor(accNo,accName,balance){
                this.accNo = accNo;
                this.accName = accName;
                this.balance = balance;
            }
         
            getBalance(){
                return (this.balance);
            }

    }

    class SavingAccount extends Account{
            constructor(accNo,accName,balance,interest) {
                super(accNo,accName,balance);
                this.interest = interest;
            }
          
             getBalance(){
                return (super.getBalance()+this.interest);
            }
    }

    class CurrentAccount extends Account{
             constructor(accNo,accName,balance,cashCredit) {
                super(accNo,accName,balance);
                this.cashCredit = cashCredit;
            }
          
             getBalance(){
                return super.getBalance()+this.cashCredit;
            }
            
    }
    export function getCashOfBank(account){
            account = [212,214,236,547,564];
            var totAcntCash = 0;
            let savAcnt;
            let curAcnt;
           for(let i in account){ 
                savAcnt = new SavingAccount(account[i],'raj',(i*100),(i/100));
                curAcnt = new CurrentAccount(account[i],"raj",(i*10),(i/10));
                totAcntCash = totAcntCash + (savAcnt.getBalance() + curAcnt.getBalance())
            }
            console.log(totAcntCash);
    }
  