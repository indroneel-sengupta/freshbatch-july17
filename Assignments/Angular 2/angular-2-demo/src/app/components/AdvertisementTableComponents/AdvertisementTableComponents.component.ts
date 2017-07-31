import{AdvertisementServices} from '../AddvertisementServices/AdvertisementServices.service';
import { Component } from '@angular/core';

@Component({
    selector: 'AdvertisementTableComponents',
    templateUrl: `./AdvertisementTableComponents.html`,
//     inputs:['allAds']
})
export class AdvertisementTableComponents{
      title = 'Product';
      allAds:Array<any>;
      constructor(private advService:AdvertisementServices){
            this.allAds = advService.getAllAds();
            console.log("allads = ",this.allAds)

      }
            
      onClickDelete(allAdss:Array<any>,i:number){
           // console.log(allAdss,i)
            allAdss.splice(i, 1);
           
      }
      
    
}