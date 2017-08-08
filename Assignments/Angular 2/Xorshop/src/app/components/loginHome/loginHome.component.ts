import { Component } from '@angular/core';
import {RegistrationService} from '../../services/registrationService/registrationService.service'
import {LoginService} from '../../services/loginService/loginService.service'
import { ActivatedRoute } from "@angular/router";
import { CategoriesService } from "../../services/categoriesServices/categoriesService.service";
import { Router } from "@angular/router";
import { LogoutService } from "../../services/logoutService/logoutService.service";
import { GetUserAdsService } from "../../services/getUserAdsService/getUserAdsService.service";
@Component({
  selector: 'loginHome',
  templateUrl: `./loginHome.html`,
})

export class LoginHome{
    userProducts: any;
    logoutToken: any;
    categoriesLogin: Array<any> = [];
    userName:any;
    authToken:any;
    ngOnInit() { 
        this.authToken = this.activatedRoute.snapshot.params['authToken'];
        this.userName = this.activatedRoute.snapshot.params['userName'];
        console.log("authToken = ",this.authToken , "username = ", this.userName);
    }


    constructor(private uName:RegistrationService,private getUserAds:GetUserAdsService,private router:Router ,private logoutService:LogoutService, private activatedRoute: ActivatedRoute, private categoriesService:CategoriesService){
            categoriesService.getAllCategories().subscribe((response:any)=>{
                response.data.itemList.forEach((addLogin:any) => {
                this.categoriesLogin.push(addLogin.name);
                
                });
            });
            this.authToken = this.activatedRoute.snapshot.params['authToken'];
           
            getUserAds.getUserAds(this.authToken).subscribe((response:any)=>{
                    this.userProducts = response.data.mypostList;
                    console.log(this.userProducts);
            });
            
    }
    
    

    

    onLogout(){
       this.logoutToken=this.authToken;
       this.authToken=null;
       this.logoutService.sendLogDetail(this.logoutToken).subscribe((response:any)=>{},(error:any)=>{});
    //    this.logoutService.setToken(null);
       this.router.navigate(['']);

    }

     onClickPostAdd(){
          this.router.navigate(['/postAdd' ,this.authToken , this.userName]);
     }

}