import { Component } from '@angular/core';

@Component({
  selector: 'my-app',
  template: `<AdvertisementFormComponent (childEvent)="postAd($event)"></AdvertisementFormComponent><br><AdvertisementTableComponents [allAds]="advertisements"></AdvertisementTableComponents>`,
})
export class AppComponent  { 
  name = 'Angular'; 
  advertisements:Array<any> =[];

  postAd(ad:any):void{
      this.advertisements.push(ad);
      console.log(this.advertisements);
  }
}
