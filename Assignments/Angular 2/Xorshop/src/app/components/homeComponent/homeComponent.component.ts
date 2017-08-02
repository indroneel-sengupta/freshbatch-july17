import { Component } from '@angular/core';
import {RegistrationService} from '../../services/registrationService/registrationService.service'
import {LoginService} from '../../services/loginService/loginService.service'
import { Router } from "@angular/router";
import { CategoriesService } from "../../services/categoriesServices/categoriesService.service";

@Component({
  selector: 'homeComponent',
  templateUrl: `./homeComponent.html`,
})

export class HomeComponent{
    categories:Array<any> = [];
    storeReg: any;
    successfullReg:any;
    onClickRegister(fName:string , lName:string , uName:string , pwd:string ,emailID:string, phn:string):void{
            this.storeReg = 
                {firstName:fName ,
                lastName:lName ,
                userName:uName , 
                password:pwd , 
                email:emailID , 
                phone:phn};
                 this.regService.sendRegDetail(this.storeReg).subscribe((data:any)=> { 
                                this.successfullReg=data;
                             console.log('Received products: ', this.successfullReg); 
                });
    }
    constructor(private regService:RegistrationService,private logService:LoginService , private router: Router , private categoriesService:CategoriesService ){
                categoriesService.getAllCategories().subscribe((response:any)=>{
                response.data.itemList.forEach((add:any) => {
                this.categories.push(add.name);
                console.log(this.categories);
         });
     });
    }
    
    
  




    storeLog:any;
    successfullLog:any;
    public authToken:any;
    tempSuccess:any;
    test:any;
    onClickLogin(uName:string , pwd:string ):void{
            this.storeLog = 
                {userName:uName , 
                password:pwd };
                 this.logService.sendLogDetail(this.storeLog).subscribe((data:any)=> { 
                                this.successfullLog=data;
                                console.log('Login: ', this.successfullLog);
                                this.authToken =  this.successfullLog.data['auth-token'];
                                if(this.authToken == null){
                                    this.tempSuccess = false;
                                    console.log(" tempSuccessFalse ",this.tempSuccess);
                                }else{
                                    this.tempSuccess = true;
                                    this.router.navigate(['/loginHome',this.authToken,this.storeLog.userName]);
                                }                             
                                
                });        
    }

    
}

