import { Component } from '@angular/core';
import{AdvertisementServices} from '../AddvertisementServices/AdvertisementServices.service';

@Component({
  selector: 'Home',
   template: `<AdvertisementFormComponent></AdvertisementFormComponent><br><AdvertisementTableComponents></AdvertisementTableComponents>`,
 // template:`<templateDriven></templateDriven>`
 // template:`<formBuilder></formBuilder>`
  providers:[AdvertisementServices]
})
export class Home{

}