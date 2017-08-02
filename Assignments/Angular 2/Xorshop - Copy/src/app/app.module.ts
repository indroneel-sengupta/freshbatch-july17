import { NgModule }      from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http'; 
import { RouterModule } from '@angular/router'; 

import { AppComponent }  from './app.component';
import { HomeComponent }  from './components/homeComponent/homeComponent.component';
import { LoginHome } from "./components/loginHome/loginHome.component";
import { PostAdd } from "./components/postAdd/postAdd.component";


@NgModule({
  imports:      [ BrowserModule , FormsModule , HttpModule ,RouterModule.forRoot([
                                                                {path: '', component: HomeComponent}, 
                                                                {path: 'loginHome/:authToken/:userName', component: LoginHome},
                                                                {path: 'postAdd/:authToken/:userName' , component: PostAdd} ])
],
  declarations: [ AppComponent,HomeComponent,LoginHome,PostAdd],
  bootstrap:    [ AppComponent ]
})
export class AppModule { }
