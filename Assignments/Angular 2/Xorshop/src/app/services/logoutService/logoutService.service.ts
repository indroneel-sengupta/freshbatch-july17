import { Injectable } from '@angular/core';
import { Http, Response, RequestOptions ,Headers} from '@angular/http';
import 'rxjs/add/operator/map';

@Injectable()
export class LogoutService{

    constructor(private _http: Http) { } 
    logDetail:any;
    url:any = "http://192.168.3.144:9000/logout";
    sendLogDetail(authToken:any):any{
        let headers = new Headers(); 
        let options = new RequestOptions({ headers: headers }); 
        headers.append('auth-token',authToken); 
        return this._http.delete(this.url, options).map((response: Response)=>response.json());        
    }


}