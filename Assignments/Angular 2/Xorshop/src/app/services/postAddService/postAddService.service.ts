import { Injectable } from '@angular/core';
import { Http, Response, RequestOptions ,Headers} from '@angular/http';
import 'rxjs/add/operator/map';
@Injectable()
export class PostAddService{

    constructor(private _http: Http) { } 
    postAddDetail:any;
    url:any = "http://192.168.3.144:9000/postAd";
    sendPostAddDetail(postAddDetail:any,authToken:string):any{
       this.postAddDetail = postAddDetail;
       let headers = new Headers();
       headers.append('auth-token',authToken);
       headers.append('Content-Type', 'application/json');
       let options = new RequestOptions({ headers:headers}); 
       return this._http.post(this.url, JSON.stringify(this.postAddDetail), options) .map((response: Response)=>response.json());
        
    }


}