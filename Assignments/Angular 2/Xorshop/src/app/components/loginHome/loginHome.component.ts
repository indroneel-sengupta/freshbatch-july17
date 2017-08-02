import { Component } from '@angular/core';
import {RegistrationService} from '../../services/registrationService/registrationService.service'
import {LoginService} from '../../services/loginService/loginService.service'
import { ActivatedRoute } from "@angular/router";
import { CategoriesService } from "../../services/categoriesServices/categoriesService.service";
import { Router } from "@angular/router";
@Component({
  selector: 'loginHome',
  templateUrl: `./loginHome.html`,
})

export class LoginHome{
    categoriesLogin:Array<any>=[];
    constructor(private uName:RegistrationService,private router:Router , private activatedRoute: ActivatedRoute, private categoriesService:CategoriesService){
            categoriesService.getAllCategories().subscribe((response:any)=>{
                response.data.itemList.forEach((addLogin:any) => {
                this.categoriesLogin.push(addLogin.name);
                
         });
     });
    }
    
    userName:any;
    authToken:any;

    ngOnInit() { 
        this.authToken = this.activatedRoute.snapshot.params['authToken'];
        this.userName = this.activatedRoute.snapshot.params['userName'];
        console.log("authToken = ",this.authToken , "username = ", this.userName);
     }

     onClickPostAdd(){
          this.router.navigate(['/postAdd' ,this.authToken , this.userName]);
     }

}