import { Component } from '@angular/core';
import {RegistrationService} from '../../services/registrationService/registrationService.service'
import {LoginService} from '../../services/loginService/loginService.service'
import { Router } from "@angular/router";
import { ActivatedRoute } from "@angular/router";
import { CategoriesService } from "../../services/categoriesServices/categoriesService.service";
import { PostAddService } from "../../services/postAddService/postAddService.service";
import { LogoutService } from "../../services/logoutService/logoutService.service";


@Component({
  selector: 'postAdd',
  templateUrl: `./postAdd.html`,
})

export class PostAdd{
    logoutToken: any;
    authToken1: any;
       userName1:any;
       categories:Array<any> = [];
       postAddDetails:any;
       message:string;
       constructor(private regService:RegistrationService,private logoutService:LogoutService,private postAddService:PostAddService  ,private activatedRoute:ActivatedRoute,private logService:LoginService , private router: Router , private categoriesService:CategoriesService ){
                categoriesService.getAllCategories().subscribe((response:any)=>{
                response.data.itemList.forEach((add:any) => {
                this.categories.push(add.name);

         });
     });
    }
    ngOnInit() { 
        this.authToken1= this.activatedRoute.snapshot.params['authToken'];
        this.userName1 = this.activatedRoute.snapshot.params['userName'];
        console.log(this.userName1);
     }
     onUserName(){
         this.router.navigate(['/loginHome',this.authToken1,this.userName1]);
     }
     onHome(){
        this.router.navigate(['/loginHome',this.authToken1,this.userName1]);
     }
     onCancel(){
        this.router.navigate(['/loginHome',this.authToken1,this.userName1]);
     }
     onLogout(){
       this.logoutToken=this.authToken1;
       this.authToken1=null;
       this.logoutService.sendLogDetail(this.logoutToken).subscribe((response:any)=>{},(error:any)=>{});
       this.router.navigate(['']);

    }


         onClickPostAdd(titlePA:string , namePA:string , categoryPA:string , descriptionPA:string):void{
            
            this.postAddDetails = 
                {
                 title:titlePA,
                 name:namePA,
                 category:categoryPA,
                 description:descriptionPA
                };
                console.log(this.postAddDetails);
                this.postAddService.sendPostAddDetail(this.postAddDetails,this.authToken1).subscribe((data:any)=> { 
                                           
                            if(data.data['id'] == null){
                                this.message = "Post Add Unsucessful";
                                console.log("Post Add Unsucessful");
                            }else{
                                 this.message = "Add Posted sucessfully";
                                console.log("Add Posted sucessfully");
                                console.log('Received products: ', data);
                            } 
                });

                this.router.navigate(['/loginHome',this.authToken1,this.userName1]);
    }
}