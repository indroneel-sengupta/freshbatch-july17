import { Injectable } from '@angular/core';
import { Http, Response, RequestOptions ,Headers} from '@angular/http';
import 'rxjs/add/operator/map';

@Injectable()
export class LoginService{

    constructor(private _http: Http) { } 
    logDetail:any;
    url:any = "http://192.168.3.144:9000/login";
    sendLogDetail(logDetail:any):any{
       this.logDetail = logDetail;
       let headers = new Headers({ 'Content-Type': 'application/json' });
       let options = new RequestOptions({ headers:headers}); 
       return this._http.post(this.url, JSON.stringify(this.logDetail), options) .map((response: Response)=>response.json());
        
    }


}