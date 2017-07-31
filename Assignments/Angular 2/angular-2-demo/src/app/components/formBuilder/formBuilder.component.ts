import { Component } from '@angular/core';
import { ReactiveFormsModule,FormGroup, FormControl,FormBuilder, Validators } from "@angular/forms";

@Component({
    selector: 'formBuilder',
    templateUrl: `./formBuilder.html`,
    styles: [`input.ng-invalid {border-left: 5px solid red}    input.ng-valid {border-left: 5px solid green}`]
})
export class formBuilder{
    productForm :FormGroup;
    constructor(private formBuilder: FormBuilder) { 
        this.productForm = this.formBuilder.group({
             name: ['Indroneel', [Validators.required, Validators.minLength(3), Validators.maxLength(8)]], 
             quantity: [], price: [] });
    } 
    onSubmit() {
        console.log(this.productForm.value);
    } 
}