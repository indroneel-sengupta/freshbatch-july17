import { NgModule }      from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';


import { AppComponent }  from './app.component';
import { AdvertisementFormComponent }  from './components/AdvertisementFormComponent/AdvertisementFormComponent.component';
import { AdvertisementTableComponents } from './components/AdvertisementTableComponents/AdvertisementTableComponents.component';
import { templateDriven } from './components/templateDriven/templateDriven.component'
import { modelDriven } from './components/modelDriven/modelDriven.component'
import { formBuilder } from './components/formBuilder/formBuilder.component'


import { FilterPipe } from './Pipes/customPipe.component';

@NgModule({
  imports: [BrowserModule, FormsModule , ReactiveFormsModule ],
  declarations:[AppComponent,AdvertisementFormComponent,AdvertisementTableComponents,FilterPipe],
  bootstrap:    [AppComponent]
})
export class AppModule { }
