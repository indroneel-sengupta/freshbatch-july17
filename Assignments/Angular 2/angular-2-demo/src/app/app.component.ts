import { Component } from '@angular/core';
import{AdvertisementServices} from './components/AddvertisementServices/AdvertisementServices.service';
@Component({
  selector: 'my-app',
   template: `<router-outlet></router-outlet>`,
//  // template:`<templateDriven></templateDriven>`
//  // template:`<formBuilder></formBuilder>`
//   providers:[AdvertisementServices]
})
export class AppComponent  { 
  name = 'Angular'; 
}
