import{AdvertisementServices} from '../AddvertisementServices/AdvertisementServices.service';
import { Component } from '@angular/core';
import { Router } from "@angular/router";

@Component({
    selector: 'AdvertisementTableComponents',
    templateUrl: `./AdvertisementTableComponents.html`,
//     inputs:['allAds']
})
export class AdvertisementTableComponents{
      title = 'Product';
      allAds:Array<any>;
      constructor(private advService:AdvertisementServices,private router: Router){
            this.allAds = advService.getAllAds();
           // console.log("allads = ",this.allAds)

      }
            
      onClickDelete(adv:any){
          this.advService.adDelete(adv);           
      }
  

      onEdit(adId:number){
           //this.allAds = this.advService.getAllAds();   
           this.router.navigate(['/edit', adId]);        
      }
      
    
}