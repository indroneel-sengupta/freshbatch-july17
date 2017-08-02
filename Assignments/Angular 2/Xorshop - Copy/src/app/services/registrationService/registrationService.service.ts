import { Injectable } from '@angular/core';
import { Http, Response, RequestOptions ,Headers} from '@angular/http';
import 'rxjs/add/operator/map';

@Injectable()
export class RegistrationService{

    constructor(private _http: Http) { } 
    regDetail:any;
    url:any = "http://192.168.3.144:9000/register";
    sendRegDetail(regDetail:any):any{
       this.regDetail = regDetail;
       let headers = new Headers({ 'Content-Type': 'application/json' });
       let options = new RequestOptions({ headers:headers}); 
       return this._http.post(this.url, JSON.stringify(this.regDetail), options) .map((response: Response)=>response.json());
        
    }


}