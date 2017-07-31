import { Component } from '@angular/core';
import { FormGroup, FormControl, Validators } from "@angular/forms";

@Component({
    selector: 'modelDriven',
    templateUrl: `./modelDriven.html`,
    styles: [`input.ng-invalid {border-left: 5px solid red}    input.ng-valid {border-left: 5px solid green}`]

 
})
export class modelDriven{
    productForm = new FormGroup({
         name: new FormControl(null,[Validators.required, Validators.minLength(3),Validators.maxLength(8)]),
         quantity: new FormControl(50),
         price: new FormControl(),
    });
    onSubmit() {
        console.log(this.productForm.value);
    } 
}