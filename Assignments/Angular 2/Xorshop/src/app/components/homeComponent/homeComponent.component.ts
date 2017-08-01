import { Component } from '@angular/core';
import {RegistrationService} from '../../services/registrationService/registrationService.service'

@Component({
  selector: 'homeComponent',
  templateUrl: `./homeComponent.html`,
})

export class HomeComponent{
    storeReg:any;
    successfullReg:any;
    onClickRegister(fName:string , lName:string , uName:string , pwd:string ,emailID:string, phn:string):void{
            this.storeReg = 
                {firstName:fName ,
                lastName:lName ,
                userName:uName , 
                password:pwd , 
                email:emailID , 
                phone:phn};
                 this.regService.sendRegDetail(this.storeReg).subscribe((data)=> { 
                                this.successfullReg=data;
                             console.log('Received products: ', this.successfullReg); 
                });
    }
    constructor(private regService:RegistrationService){
       
    }


}

