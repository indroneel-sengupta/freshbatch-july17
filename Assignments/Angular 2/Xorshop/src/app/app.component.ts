import { Component } from '@angular/core';
import{RegistrationService} from './services/registrationService/registrationService.service';
import{LoginService} from './services/loginService/loginService.service';
import { HttpModule } from '@angular/http'; 
import { CategoriesService } from "./services/categoriesServices/categoriesService.service";
import { PostAddService } from "./services/postAddService/postAddService.service";

@Component({
  selector: 'my-app',
  template: `<router-outlet></router-outlet>`,
  providers:[RegistrationService,LoginService,CategoriesService,PostAddService]
  
})

export class AppComponent  {

  
}
