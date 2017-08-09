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
var router_1 = require("@angular/router");
var categoriesService_service_1 = require("../../services/categoriesServices/categoriesService.service");
var router_2 = require("@angular/router");
var LoginHome = (function () {
    function LoginHome(uName, router, activatedRoute, categoriesService) {
        var _this = this;
        this.uName = uName;
        this.router = router;
        this.activatedRoute = activatedRoute;
        this.categoriesService = categoriesService;
        this.categoriesLogin = [];
        categoriesService.getAllCategories().subscribe(function (response) {
            response.data.itemList.forEach(function (addLogin) {
                _this.categoriesLogin.push(addLogin.name);
            });
        });
    }
    LoginHome.prototype.ngOnInit = function () {
        this.authToken = this.activatedRoute.snapshot.params['authToken'];
        this.userName = this.activatedRoute.snapshot.params['userName'];
        console.log("authToken = ", this.authToken, "username = ", this.userName);
    };
    LoginHome.prototype.onClickPostAdd = function () {
        this.router.navigate(['/postAdd', this.authToken, this.userName]);
    };
    return LoginHome;
}());
LoginHome = __decorate([
    core_1.Component({
        selector: 'loginHome',
        templateUrl: "./loginHome.html",
    }),
    __metadata("design:paramtypes", [registrationService_service_1.RegistrationService, router_2.Router, router_1.ActivatedRoute, categoriesService_service_1.CategoriesService])
], LoginHome);
exports.LoginHome = LoginHome;
//# sourceMappingURL=loginHome.component.js.map