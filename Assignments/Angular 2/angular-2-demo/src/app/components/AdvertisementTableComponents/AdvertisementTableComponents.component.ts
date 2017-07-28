
import { Component } from '@angular/core';
@Component({
    selector: 'AdvertisementTableComponents',
    templateUrl: `./AdvertisementTableComponents.html`,
    inputs:['allAds']
})
export class AdvertisementTableComponents{
      title = 'Product';
      allAds:Array<any>;
      
    
}