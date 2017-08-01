import { NgModule }      from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http'; 
import { RouterModule } from '@angular/router'; 


import { AppComponent }  from './app.component';
import { AdvertisementFormComponent }  from './components/AdvertisementFormComponent/AdvertisementFormComponent.component';
import { AdvertisementTableComponents } from './components/AdvertisementTableComponents/AdvertisementTableComponents.component';
import { templateDriven } from './components/templateDriven/templateDriven.component'
import { modelDriven } from './components/modelDriven/modelDriven.component'
import { formBuilder } from './components/formBuilder/formBuilder.component'
import { Home } from './components/HomeComponent/home.component'
import { Edit } from './components/EditProduct/EditProduct.component'

import { FilterPipe } from './Pipes/customPipe.component';

@NgModule({
  imports: [BrowserModule, FormsModule , ReactiveFormsModule ,  HttpModule , RouterModule.forRoot([
                                                                                 {path: '', component: Home},
                                                                                 {path: 'edit/:adId', component: Edit} ])
],
  declarations:[AppComponent,Home,AdvertisementFormComponent,AdvertisementTableComponents,FilterPipe, Edit],
  bootstrap:    [AppComponent]
})
export class AppModule { }
