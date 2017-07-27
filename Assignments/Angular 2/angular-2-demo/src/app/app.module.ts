import { NgModule }      from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent }  from './app.component';
import { AdvertisementFormComponent }  from './components/AdvertisementFormComponent/AdvertisementFormComponent.component';

@NgModule({
  imports:      [ BrowserModule ],
  declarations: [ AppComponent,AdvertisementFormComponent ],
  bootstrap:    [ AppComponent ]
})
export class AppModule { }
