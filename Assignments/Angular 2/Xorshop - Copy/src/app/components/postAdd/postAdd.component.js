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
var registrationService_service_1 = require("../../services/registrationService/registrationService.service");
var loginService_service_1 = require("../../services/loginService/loginService.service");
var router_1 = require("@angular/router");
var router_2 = require("@angular/router");
var categoriesService_service_1 = require("../../services/categoriesServices/categoriesService.service");
var postAddService_service_1 = require("../../services/postAddService/postAddService.service");
var PostAdd = (function () {
    function PostAdd(regService, postAddService, activatedRoute, logService, router, categoriesService) {
        var _this = this;
        this.regService = regService;
        this.postAddService = postAddService;
        this.activatedRoute = activatedRoute;
        this.logService = logService;
        this.router = router;
        this.categoriesService = categoriesService;
        this.categories = [];
        categoriesService.getAllCategories().subscribe(function (response) {
            response.data.itemList.forEach(function (add) {
                _this.categories.push(add.name);
            });
        });
    }
    PostAdd.prototype.ngOnInit = function () {
        this.authToken1 = this.activatedRoute.snapshot.params['authToken'];
        this.userName1 = this.activatedRoute.snapshot.params['userName'];
        console.log(this.userName1);
    };
    PostAdd.prototype.onClickPostAdd = function (titlePA, namePA, categoryPA, descriptionPA) {
        this.postAddDetails =
            {
                title: titlePA,
                name: namePA,
                category: categoryPA,
                description: descriptionPA
            };
        console.log(this.postAddDetails);
        this.postAddService.sendPostAddDetail(this.postAddDetails, this.authToken1).subscribe(function (data) {
            //  this.successfullReg=data;
            console.log('Received products: ', data);
        });
    };
    return PostAdd;
}());
PostAdd = __decorate([
    core_1.Component({
        selector: 'postAdd',
        templateUrl: "./postAdd.html",
    }),
    __metadata("design:paramtypes", [registrationService_service_1.RegistrationService, postAddService_service_1.PostAddService, router_2.ActivatedRoute, loginService_service_1.LoginService, router_1.Router, categoriesService_service_1.CategoriesService])
], PostAdd);
exports.PostAdd = PostAdd;
//# sourceMappingURL=postAdd.component.js.map