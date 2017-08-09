"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
var core_1 = require("@angular/core");
var http_1 = require("@angular/http");
require("rxjs/add/operator/map");
var PostAddService = (function () {
    function PostAddService(_http) {
        this._http = _http;
        this.url = "http://192.168.3.144:9000/postAd";
    }
    PostAddService.prototype.sendPostAddDetail = function (postAddDetail, authToken) {
        this.postAddDetail = postAddDetail;
        var headers = new http_1.Headers();
        headers.append('auth-token', authToken);
        headers.append('Content-Type', 'application/json');
        var options = new http_1.RequestOptions({ headers: headers });
        return this._http.post(this.url, JSON.stringify(this.postAddDetail), options).map(function (response) { return response.json(); });
    };
    return PostAddService;
}());
PostAddService = __decorate([
    core_1.Injectable(),
    __metadata("design:paramtypes", [http_1.Http])
], PostAddService);
exports.PostAddService = PostAddService;
//# sourceMappingURL=postAddService.service.js.map