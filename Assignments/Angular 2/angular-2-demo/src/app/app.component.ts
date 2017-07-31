import { Component } from '@angular/core';
import{AdvertisementServices} from './components/AddvertisementServices/AdvertisementServices.service';
@Component({
  selector: 'my-app',
   template: `<AdvertisementFormComponent></AdvertisementFormComponent><br><AdvertisementTableComponents></AdvertisementTableComponents>`,
 // template:`<templateDriven></templateDriven>`
 // template:`<formBuilder></formBuilder>`
  providers:[AdvertisementServices]
})
export class AppComponent  { 
  name = 'Angular'; 
  // advertisements:Array<any> =[];
  // constructor(private adService: AdvertisementServices) {
    
  // }


  // postAd(ad:any):void{
  //     this.advertisements.push(ad);
  //   //  console.log(this.advertisements);
  // }
}
