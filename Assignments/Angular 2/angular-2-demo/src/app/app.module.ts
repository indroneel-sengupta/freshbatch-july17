import { NgModule }      from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent }  from './app.component';
import { AdvertisementFormComponent }  from './components/AdvertisementFormComponent/AdvertisementFormComponent.component';
import { AdvertisementTableComponents } from './components/AdvertisementTableComponents/AdvertisementTableComponents.component';
import { FilterPipe } from './Pipes/customPipe.component';

@NgModule({
  imports:      [ BrowserModule ],
  declarations: [ AppComponent,AdvertisementFormComponent, AdvertisementTableComponents,FilterPipe],
  bootstrap:    [ AppComponent ]
})
export class AppModule { }
