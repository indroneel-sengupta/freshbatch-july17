import { NgModule }      from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http'; 

import { AppComponent }  from './app.component';
import { HomeComponent }  from './components/homeComponent/homeComponent.component';


@NgModule({
  imports:      [ BrowserModule , FormsModule , HttpModule],
  declarations: [ AppComponent,HomeComponent],
  bootstrap:    [ AppComponent ]
})
export class AppModule { }
