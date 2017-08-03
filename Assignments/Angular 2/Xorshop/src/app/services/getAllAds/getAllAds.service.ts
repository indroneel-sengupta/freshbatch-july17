import { Injectable } from '@angular/core';
import { Http, Response, RequestOptions ,Headers} from '@angular/http';
import 'rxjs/add/operator/map';

@Injectable()
export class GetAllAds{

    constructor(private _http: Http) { } 
    
    url:any = "http://192.168.3.144:9000/posts/search";

    getAllAds(){
       return this._http.get(this.url) .map((response: Response)=>response.json());
        
    }


}