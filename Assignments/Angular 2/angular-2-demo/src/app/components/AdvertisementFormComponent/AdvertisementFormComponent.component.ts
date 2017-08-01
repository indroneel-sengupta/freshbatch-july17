
import { Component, EventEmitter } from '@angular/core';
import{AdvertisementServices} from '../AddvertisementServices/AdvertisementServices.service';

@Component({
    selector: 'AdvertisementFormComponent',
    templateUrl: `./AdvertisementFormComponent.html`,
    
})
export class AdvertisementFormComponent{
      childEvent = new EventEmitter<Adv>();
      addId: number = 0;
      title = 'Product';
      placeholder = 'Indroneel Sengupta';
      category = [
                {id:1,name:'Hardware'},
                {id:1,name:'Furniture'},
                {id:1,name:'Mobile'}
     ];
     adv:Array<any> = [];

     constructor(private advService:AdvertisementServices){}
     onOkClick(titleRef:string , nameRef:string , priceRef:number , catRef:string):void{
            // let adv = new Adv(titleRef,nameRef,priceRef,catRef);
            // this.childEvent.emit(adv);
            this.addId += 1;
            this.advService.addNewAdd(titleRef,nameRef,priceRef,catRef,this.addId);

            console.log(titleRef,nameRef,priceRef,catRef);
       
     }
}

export class Adv{
    title:string;
    name:string;
    price:number;
    category:string;

    constructor(title:string , name:string , price:number , category:string){
        this.title = title;
        this.name = name;
        this.price = price;
        this.category = category;
    }
}