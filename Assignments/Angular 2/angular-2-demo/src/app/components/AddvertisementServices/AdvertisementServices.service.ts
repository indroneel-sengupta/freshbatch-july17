import { Injectable } from '@angular/core';
@Injectable()

export class AdvertisementServices{
      advertisements:Array<any> =[];
      obj:Array <any> = [];
      addNewAdd(titleRef:string,nameRef:string,priceRef:number,catRef:string):void{
            this.obj = [titleRef,nameRef,priceRef,catRef]
            this.advertisements.push(this.obj);
      }

      getAllAds():Array<any>{
            return (this.advertisements);
      }



}