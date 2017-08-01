import { Injectable } from '@angular/core';
@Injectable()

export class AdvertisementServices{
      advertisements:Array<any> =[];
      obj:Array <any> = [];
      addNewAdd(titleRef:string,nameRef:string,priceRef:number,catRef:string,addId:number):void{
            this.obj = [titleRef,nameRef,priceRef,catRef,addId]
            this.advertisements.push(this.obj);
      }

      getAllAds():Array<any>{
            return (this.advertisements);
      }

      getSingleAdd(adId:number):Array<any>{
            for(let i=0 ; i<this.advertisements.length ; i++){
                  if(adId == this.advertisements[i].addId){
                  console.log("getsingleAdd = ",this.advertisements);
                       return (this.advertisements[i]);  
                  }
            }
            
      }
      adDelete(adv:any){
            let i=this.advertisements.length;
                    console.log("Adv 1= ",adv);
                        while(i--)
                        {
                            if(this.advertisements[i]===adv){
                                console.log("Array Trace = ",this.advertisements[i]);
                                this.advertisements.splice(i,1);
                            }
                        }

      }



}