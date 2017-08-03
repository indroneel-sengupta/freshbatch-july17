import { Component } from '@angular/core';
import{RegistrationService} from './services/registrationService/registrationService.service';
import{LoginService} from './services/loginService/loginService.service';
import { HttpModule } from '@angular/http'; 
import { CategoriesService } from "./services/categoriesServices/categoriesService.service";
import { PostAddService } from "./services/postAddService/postAddService.service";
import { GetAllAds } from "./services/getAllAds/getAllAds.service";
import { LogoutService } from "./services/logoutService/logoutService.service";
import { GetUserAdsService } from "./services/getUserAdsService/getUserAdsService.service";

@Component({
  selector: 'my-app',
  template: `<router-outlet></router-outlet>`,
  providers:[RegistrationService,LoginService,LogoutService,CategoriesService,PostAddService,GetAllAds,GetUserAdsService]
  
})

export class AppComponent  {

  
}
