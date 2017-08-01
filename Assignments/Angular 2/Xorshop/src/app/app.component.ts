import { Component } from '@angular/core';
import{RegistrationService} from './services/registrationService/registrationService.service';
import { HttpModule } from '@angular/http'; 

@Component({
  selector: 'my-app',
  template: `<homeComponent></homeComponent>`,
  providers:[RegistrationService]
})
export class AppComponent  {

  
}
