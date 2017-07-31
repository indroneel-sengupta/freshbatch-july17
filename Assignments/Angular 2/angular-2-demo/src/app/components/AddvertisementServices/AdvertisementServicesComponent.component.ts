import { AdvertisementServices } from './AdvertisementServices.service';
import { Component } from "@angular/core";

@Component({
     selector: 'sample', 
     templateUrl: './AdvertisementService.html', 
     providers: [AdvertisementServices] //Service registration 
    
})

export class AdvertisementServicesComponents{
    constructor(addService: AdvertisementServices){
        console.log("ADDSS = ",addService.getAds());

    }
}