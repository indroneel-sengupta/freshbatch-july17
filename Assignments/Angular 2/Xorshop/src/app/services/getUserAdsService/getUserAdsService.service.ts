import { Injectable } from '@angular/core';
import { Http, Response, RequestOptions ,Headers} from '@angular/http';
import 'rxjs/add/operator/map';

@Injectable()
export class GetUserAdsService{

    constructor(private _http: Http) { } 
    
    url:any = "http://192.168.3.144:9000/posts";

    getUserAds(authToken:any):any{
      
        let headers = new Headers();
        headers.append('auth-token',authToken);
        console.log("service auth-token", authToken);
        headers.append('Content-Type', 'application/json');
        let options = new RequestOptions({ headers:headers});
        return this._http.get(this.url,options) .map((response: Response)=>response.json());
        
    }


}