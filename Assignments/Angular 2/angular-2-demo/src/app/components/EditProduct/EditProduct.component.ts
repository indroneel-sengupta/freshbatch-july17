import { Component } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import{AdvertisementServices} from '../AddvertisementServices/AdvertisementServices.service';


@Component({
   selector: 'Edit',
   templateUrl: `./editAdv.html`,
})

export class Edit{
        adId:number;
        constructor(private activatedRoute: ActivatedRoute,private advService:AdvertisementServices) {
     
                this.adId = this.activatedRoute.snapshot.params[this.adId];
                this.advService.getSingleAdd(this.adId)


        }
        // advService.getSingleAdd()




}
